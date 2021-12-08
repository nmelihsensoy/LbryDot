using Dapper;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{

    internal class BorrowingRepository : Abstract.RepositoryBase, Abstract.IBorrowingRepository
    {
        public BorrowingRepository(IDbTransaction dbTransaction) : base(dbTransaction)
        {
        }

        public int Add(BorrowingModel model)
        {
            return dbConnection.Execute("INSERT INTO Borrowing (book_id, student_number, issued_date, due_date) values (@book_id, @student_number, @issued_date, @due_date)",
                new
                {
                    book_id = model.book.book_id,
                    student_number = model.student.student_number,
                    issued_date = model.issued_date,
                    due_date = model.due_date
                },
                transaction: dbTransaction);
        }

        public int Delete(BorrowingModel model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BorrowingModel> GetAll()
        {

            throw new NotImplementedException();
        }

        public IEnumerable<BorrowingModel> GetAllJoined(int StudentNumber)
        {
            var sql = @"SELECT * FROM Borrowing AS B
                LEFT JOIN Books AS BS ON BS.book_id = B.book_id
                WHERE student_number = @id
                ORDER BY due_date ASC";
            
            return dbConnection.Query<BorrowingModel, BookModel, BorrowingModel>(sql, (borrowing, book) => { borrowing.book = book; return borrowing; }, new { id = StudentNumber}, splitOn:"book_id", transaction: dbTransaction);
        }

        public IEnumerable<BorrowingModel> GetActives(int StudentNumber, int FirstRowCount)
        {
            var sql = @"SELECT * FROM Borrowing AS B
                LEFT JOIN Books AS BS ON BS.book_id = B.book_id
                WHERE student_number = @id AND returned_date IS NULL
                ORDER BY due_date ASC
                LIMIT @row_count
                ";

            return dbConnection.Query<BorrowingModel, BookModel, BorrowingModel>(sql, (borrowing, book) => { borrowing.book = book; return borrowing; }, new { id = StudentNumber, row_count = FirstRowCount }, splitOn: "book_id", transaction: dbTransaction);
        }

        public BorrowingModel GetById(int Id)
        {
            throw new NotImplementedException();

        }

        public void Update(BorrowingModel model)
        {
            throw new NotImplementedException();
        }

        public int ReturnBorrow(BorrowingModel Borrowing)
        {
            var sql = @"UPDATE Borrowing SET returned_date = @date, amount_of_fine = @fine WHERE borrow_id = @id;";
            return dbConnection.Execute(sql,
                new
                {
                    date = Borrowing.returned_date,
                    fine = Borrowing.amount_of_fine,
                    id = Borrowing.borrow_id
                },
                transaction: dbTransaction);
        }

        public Tuple<List<StatModel>, List<StatModel>> GetBorrowingStats(int LastDayCount = 5)
        {
            var sql = @"SELECT issued_date as date, COUNT(*) as count FROM Borrowing
                        WHERE issued_date > (SELECT DATE('now','-4 day'))
                        GROUP BY strftime('%d', issued_date)
                        ORDER BY issued_date DESC 
                        LIMIT @day_count;

                        SELECT returned_date as date, COUNT(*) as count FROM Borrowing
                        WHERE returned_date IS NOT NULL
                        GROUP BY strftime('%d', returned_date)
                        ORDER BY returned_date DESC 
                        LIMIT @day_count;
                        ";

            var multi = dbConnection.QueryMultiple(sql, new { day_count = LastDayCount }, dbTransaction);
            return Tuple.Create(multi.Read<StatModel>().ToList(), multi.Read<StatModel>().ToList());
        }

        public IEnumerable<BorrowingModel> GetAllBorrowingsForBook(int BookId)
        {
            var sql = @"SELECT * FROM Borrowing AS B
                LEFT JOIN Students AS S ON S.student_number = B.student_number
                WHERE B.book_id = @id AND returned_date IS NOT NULL
                ORDER BY B.returned_date ASC";

            return dbConnection.Query<BorrowingModel, StudentModel, BorrowingModel>(sql, (borrowing, student) => { borrowing.student = student; return borrowing; }, new { id = BookId }, splitOn: "student_number", transaction: dbTransaction);
        }

    }
}
