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

        public IEnumerable<BorrowingModel> GetAllJoined(int StudentNumber, int FirstRowCount)
        {
            string sql;
            if (FirstRowCount > 0)
            {
                sql = @"SELECT * FROM Borrowing AS B
                LEFT JOIN Books AS BS ON BS.book_id = B.book_id
                WHERE student_number = @id
                ORDER BY due_date DESC
                LIMIT 4
                ";
            }
            else
            {
                sql = @"SELECT * FROM Borrowing AS B
                LEFT JOIN Books AS BS ON BS.book_id = B.book_id
                WHERE student_number = @id
                ";
            }
            
            return dbConnection.Query<BorrowingModel, BookModel, BorrowingModel>(sql, (borrowing, book) => { borrowing.book = book; return borrowing; }, new { id = StudentNumber}, splitOn:"book_id", transaction: dbTransaction);
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
                    returned_date = Borrowing.returned_date,
                    amount_of_fine = Borrowing.amount_of_fine,
                    id = Borrowing.borrow_id
                },
                transaction: dbTransaction);
        }

    }
}
