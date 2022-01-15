using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    //Definitions of function or varibles that can only used in Data Layer to help another function or variable.
    //Creating with no relation any of classes is required.
    public static class Helpers
    {
        public static string GetConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        
        public static string ParseConnectionString(string ConnectionStr, string id="Data Source")
        {
            var builder = new System.Data.Common.DbConnectionStringBuilder();
            builder.ConnectionString = ConnectionStr;
            return builder[id].ToString();
        }

        public static string GetAppSetting(string id)
        {
            return ConfigurationManager.AppSettings.Get(id);
        }

    }
}
