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
            throw new NotImplementedException();
        }

        public int Delete(BorrowingModel model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BorrowingModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public BorrowingModel GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(BorrowingModel model)
        {
            throw new NotImplementedException();
        }
    }
}
