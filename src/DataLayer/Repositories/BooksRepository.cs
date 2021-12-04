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
    }
}
