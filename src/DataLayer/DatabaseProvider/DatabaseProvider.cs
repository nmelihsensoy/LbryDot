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

        public void ResetDatabase()
        {
            string SourceFile = Helpers.ParseConnectionString(Helpers.GetConnectionString());
            string DestPath = System.IO.Path.GetDirectoryName(SourceFile) + @"\" + System.IO.Path.GetFileNameWithoutExtension(SourceFile);
            if (System.IO.File.Exists(SourceFile) && System.IO.File.Exists(DestPath + ".bak")) System.IO.File.Delete(SourceFile);
            System.IO.File.Copy(DestPath + ".bak", DestPath + ".db");
        }

    }
}
