using DataLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataLayer.DatabaseProvider
{
    //Database provider class for SQLite Database.
    public class DatabaseProvider : IDatabaseProvider
    {
        private string DbFolder;
        private static string RegexPathKey = @"\$LbryAppDataPath\$";

        public DatabaseProvider()
        {
            DbFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\" + Helpers.GetAppSetting("AppDataFolderName");
        }

        private string ConstructDbFilePath()
        {
            return Regex.Replace(Helpers.GetConnectionString(), RegexPathKey, DbFolder);
        }

        public IDbConnection ObtainConnection()
        {
            return new SQLiteConnection(ConstructDbFilePath());
        }

        public void ResetDatabase() {
            string DbFile = Regex.Replace(Helpers.ParseConnectionString(Helpers.GetConnectionString()), RegexPathKey, DbFolder);
            if (System.IO.File.Exists(DbFile)) System.IO.File.Delete(DbFile);
            System.IO.File.Copy(Helpers.ParseConnectionString(Helpers.GetConnectionString("Empty")), DbFile);
        }

    }
}
