using DataLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DatabaseProvider
{
    //Database provider class for SQLite Database.
    public class DatabaseProvider : IDatabaseProvider
    {
        public IDbConnection ObtainConnection()
        {
            return new SQLiteConnection(Helpers.GetConnectionString());
        }
    }
}
