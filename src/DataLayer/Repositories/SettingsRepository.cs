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
    internal class SettingsRepository : Abstract.RepositoryBase, Abstract.ISettingsRepository
    {
        public SettingsRepository(IDbTransaction dbTransaction) : base(dbTransaction) {
        }

        private static int SettingsId = 1;

        public SettingsModel GetSettings()
        {
            return dbConnection.Query<SettingsModel>("SELECT * FROM System_Parameters WHERE id = @id;", new { id = SettingsId }, transaction: dbTransaction).FirstOrDefault();
        }

        public int UpdateSettings(SettingsModel NewSettings)
        {
            return dbConnection.Execute("UPDATE System_Parameters SET daily_fine_amount = @daily_fine_amount WHERE id = @id;",
                new {
                    daily_fine_amount = NewSettings.daily_fine_amount,
                    id = SettingsId
                },
                transaction: dbTransaction);
        }
    }
}
