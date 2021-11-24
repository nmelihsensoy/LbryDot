using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    internal class SettingsRepository : Abstract.RepositoryBase, Abstract.ISettingsRepository
    {
        public SettingsRepository(IDbTransaction dbTransaction) : base(dbTransaction) {
        }

        public int Add(SettingsModel model)
        {
            throw new NotImplementedException();
        }

        public int Delete(SettingsModel model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SettingsModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public SettingsModel GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(SettingsModel model)
        {
            throw new NotImplementedException();
        }
    }
}
