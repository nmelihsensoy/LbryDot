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

            DynamicParameters Params = new DynamicParameters();
            Params.Add("@book_id", model.book.book_id, DbType.Int32, ParameterDirection.Input);
            Params.Add("@student_number", model.student.student_number, DbType.Int32, ParameterDirection.Input);
            Params.Add("@issued_date", model.issued_date, DbType.DateTime, ParameterDirection.Input);
            Params.Add("@due_date", model.due_date, DbType.DateTime, ParameterDirection.Input);
            Params.Add("@amount_of_fine", model.amount_of_fine, DbType.Int32, ParameterDirection.Input);

            if (model.returned_date == DateTime.MinValue)
            {
                Params.Add("returned_date", null);
            }
            else
            {
                Params.Add("returned_date", model.returned_date, DbType.DateTime, ParameterDirection.Input);
            }

            return dbConnection.Execute("INSERT INTO Borrowing (book_id, student_number, issued_date, due_date, returned_date, amount_of_fine) values (@book_id, @student_number, @issued_date, @due_date, @returned_date, @amount_of_fine)",
                Params,
                transaction: dbTransaction);
        }

        public int Borrow(BorrowingModel model)
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
                ORDER BY returned_date DESC NULLS FIRST, due_date ASC";
            
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

        public int Update(BorrowingModel model)
        {
            throw new NotImplementedException();
        }

        public int GetTotalFineForStudent(int StudentId)
        {
            return dbConnection.QueryFirstOrDefault<int>("SELECT IFNULL(SUM(amount_of_fine), 0) FROM Borrowing WHERE returned_date IS NOT NULL AND student_number=@student_id; ", new { student_id = StudentId }, transaction: dbTransaction);
        }

        public int GetActiveFineForStudent(int StudentId)
        {
            var sql = @"
            SELECT (IFNULL(SUM(JULIANDAY(date('now', 'localtime'))-JULIANDAY(date(due_date))), 0)*(SELECT daily_fine_amount FROM System_Parameters WHERE id=1)) as ActiveTotalFee 
            FROM Borrowing 
            WHERE returned_date IS NULL AND due_date<date('now', 'localtime') AND student_number=@student_id;
            ";
            return dbConnection.QueryFirstOrDefault<int>(sql, new { student_id = StudentId }, transaction: dbTransaction);
        }

        public int UpdateBook(int Id, int NewId=1)
        {
            var sql = @"UPDATE Borrowing SET book_id = @new_id WHERE book_id = @id;";
            return dbConnection.Execute(sql,
                new
                {
                    id = Id,
                    new_id = NewId
                },
                transaction: dbTransaction);
        }
   
        public int UpdateStudent(int Id, int NewId=1)
        {
            var sql = @"UPDATE Borrowing SET student_number = @new_id WHERE student_number = @id;";
            return dbConnection.Execute(sql,
                new
                {
                    id = Id,
                    new_id = NewId
                },
                transaction: dbTransaction);
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

        public Dictionary<DateTime, int[]> GetBorrowingStats(int LastDayCount = 5)
        {
            var sql = @"SELECT issued_date as date, COUNT(*) as count FROM Borrowing
                        WHERE issued_date > (SELECT DATE('now', @date_param))
                        GROUP BY strftime('%d', issued_date)
                        ORDER BY issued_date DESC 
                        LIMIT @day_count;

                        SELECT returned_date as date, COUNT(*) as count FROM Borrowing
                        WHERE returned_date IS NOT NULL
                        GROUP BY strftime('%d', returned_date)
                        ORDER BY returned_date DESC 
                        LIMIT @day_count;
                        ";
            Dictionary<DateTime, int[]> Dict;
            //Eg: date_param = '-4 day' 
            using (var multi = dbConnection.QueryMultiple(sql, new { day_count = LastDayCount, date_param = '-' + LastDayCount.ToString() + " day" }, dbTransaction))
            {
                var Dict1 = multi.Read<StatModel>().ToDictionary(pair => pair.date.Date, pair => pair.count);
                var Dict2 = multi.Read<StatModel>().ToDictionary(pair => pair.date.Date, pair => pair.count);

                //Fastest merging method according here
                //https://stackoverflow.com/questions/44140066/c-sharp-merging-multiple-dictionaries-into-one
                Dict = new Dictionary<DateTime, int[]>(Dict1.Count + Dict2.Count);
                foreach (var Day in Dict1)
                {
                    Dict.Add(Day.Key, new int[] { Day.Value, 0 });
                }

                foreach (var Day in Dict2)
                {
                    if (!Dict.ContainsKey(Day.Key))
                    {
                        Dict.Add(Day.Key, new int[] { 0, Day.Value });
                    }

                    (Dict[Day.Key] as int[])[1] = Day.Value;
                }
            }
            return Dict;
        }

        public IEnumerable<BorrowingModel> GetAllBorrowingsForBook(int BookId)
        {
            var sql = @"SELECT * FROM Borrowing AS B
                LEFT JOIN Students AS S ON S.student_number = B.student_number
                WHERE B.book_id = @id
                ORDER BY B.returned_date DESC NULLS FIRST";

            return dbConnection.Query<BorrowingModel, StudentModel, BorrowingModel>(sql, (borrowing, student) => { borrowing.student = student; return borrowing; }, new { id = BookId }, splitOn: "student_number", transaction: dbTransaction);
        }

        public int GetActiveBorrowingCountForStudent(int StudentId)
        {
            return dbConnection.QueryFirstOrDefault<int>("SELECT COUNT(*) FROM Borrowing WHERE returned_date IS NULL AND student_number=@student_id;", new { student_id = StudentId}, transaction: dbTransaction);
        }

        public IEnumerable<BorrowingModel> GetAllBorrowingsForStudent(int StudentId)
        {
            var sql = @"SELECT * FROM Borrowing AS B
                LEFT JOIN Books AS BK ON BK.book_id = B.book_id
                WHERE B.student_number = @id
                ORDER BY returned_date DESC NULLS FIRST";

            return dbConnection.Query<BorrowingModel, BookModel, BorrowingModel>(sql, (borrowing, book) => { borrowing.book = book; return borrowing; }, new { id = StudentId }, splitOn: "book_id", transaction: dbTransaction);
        }

        public IEnumerable<StatModel> GetFullChartData()
        {
            var sql = @"SELECT A.returned_date AS date, (LessThanCount-A.RETURNED_COUNT) AS count FROM (SELECT BRW.returned_date, BRW.issued_date, SUM(IFNULL(B.LessThanCount, 0)) as LessThanCount 
                        FROM Borrowing BRW
                        LEFT JOIN (SELECT issued_date, COUNT(*) as LessThanCount FROM Borrowing GROUP BY issued_date)B ON B.issued_date <=  BRW.returned_date
                        WHERE BRW.returned_date IS NOT NULL
                        GROUP BY BRW.borrow_id, BRW.returned_date
                        ORDER BY BRW.returned_date ASC) LTC
                        LEFT JOIN (SELECT returned_date, SUM(NUM) OVER(ORDER BY returned_date ASC) AS RETURNED_COUNT FROM (SELECT returned_date, COUNT(*) AS NUM FROM Borrowing WHERE returned_date IS NOT NULL GROUP BY returned_date))A ON A.returned_date = LTC.returned_date
                        GROUP BY LTC.returned_date;";

            return dbConnection.Query<StatModel>(sql, new DynamicParameters(), transaction: dbTransaction);
        }

    }
}
