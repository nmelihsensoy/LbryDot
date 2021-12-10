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
            return dbConnection.Execute("DELETE FROM Books WHERE book_id=@id", new { id = model.book_id }, dbTransaction);
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

        public int Update(BookModel model)
        {
            return dbConnection.Execute("UPDATE Books SET isbn=@isbn, title=@title, date_of_publication=@date_of_publication, author=@author, number_of_pages=@number_of_pages, category=@category, language=@language, book_cover=@book_cover, shelf_number=@shelf_number WHERE book_id = @book_id;", model,
                transaction: dbTransaction);
        }

        public int[] AvailableBooks()
        {
            int[] a = new int[2];
            string sql = "SELECT COUNT(*) FROM Books; SELECT COUNT(*) FROM Books WHERE is_available = @is_available;";
            var multi = dbConnection.QueryMultiple(sql, new { is_available = 1 }, dbTransaction);
            a[0] = multi.Read<int>().First(); //All books
            a[1] = multi.Read<int>().Single(); //Available Books
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

        public IEnumerable<BookModel> Search(string Text)
        {
            return dbConnection.Query<BookModel>("SELECT * FROM Books WHERE isbn LIKE @text OR title LIKE @text OR category LIKE @text;",
                new { text = "%" + Text + "%" },
                transaction: dbTransaction);
        }

    }
}
