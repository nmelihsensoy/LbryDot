using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Abstract
{

    //Generic interface for getting connection.
    //Desired database providers connection logic can be applied with implementing ObtainConnection
    public interface IDatabaseProvider
    {
        IDbConnection ObtainConnection();
        void ResetDatabase();
    }
}
