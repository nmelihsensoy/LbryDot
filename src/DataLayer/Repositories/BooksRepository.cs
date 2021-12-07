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
    internal class BooksRepository : Abstract.RepositoryBase, Abstract.IBooksRepository
    {
        public BooksRepository(IDbTransaction dbTransaction) : base(dbTransaction)
        {
        }

        public int Add(BookModel model)
        {
            return dbConnection.Execute("INSERT INTO Books (isbn, title, date_of_publication, author, number_of_pages, category, language, book_cover, shelf_number) values (@isbn, @title, @date_of_publication, @author, @number_of_pages, @category, @language, @book_cover, @shelf_number)",
                model,
                transaction: dbTransaction);
        }

        public int Delete(BookModel model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookModel> GetAll()
        {
            return dbConnection.Query<BookModel>("SELECT * FROM Books",
                new DynamicParameters(),
                transaction: dbTransaction);
        }

        public BookModel GetById(int Id)
        {
            return dbConnection.Query<BookModel>("SELECT * FROM Books WHERE book_id = @id;", new { id = Id }, transaction: dbTransaction).FirstOrDefault();
        }

        public void Update(BookModel model)
        {
            throw new NotImplementedException();
        }

        public int[] AvailableBooks()
        {
            int[] a = { -1, -1};
            //ExecuteScalar<int>("SELECT COUNT(*) FROM customers");
            string sql = "SELECT COUNT(*) FROM Books; SELECT COUNT(*) FROM Books WHERE is_available = @is_available;";
            var multi = dbConnection.QueryMultiple(sql, new { is_available = 1 });
            a[1] = multi.Read<int>().Single();
            a[0] = multi.Read<int>().Single();
            return a;
        }

        public int ChangeBookAvailability(int Id, short IsAvailable)
        {
            var sql = @"UPDATE Books SET is_available = @is_available WHERE book_id = @id;";
            return dbConnection.Execute(sql,
                new
                {
                    is_available = IsAvailable,
                    id = Id
                },
                transaction: dbTransaction);
        }

    }
}
