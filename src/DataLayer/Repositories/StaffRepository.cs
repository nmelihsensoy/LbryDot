using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    internal class StaffRepository : Abstract.RepositoryBase, Abstract.IStaffRepository
    {
        public StaffRepository(IDbTransaction dbTransaction) : base(dbTransaction)
        {
        }

        public int Add(StaffModel model)
            {
                throw new NotImplementedException();
            }

        public int Delete(StaffModel model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StaffModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public StaffModel GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(StaffModel model)
        {
            throw new NotImplementedException();
        }
    }
}
