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
            throw new NotImplementedException();
        }

        public int Delete(BookModel model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public BookModel GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(BookModel model)
        {
            throw new NotImplementedException();
        }
    }
}
