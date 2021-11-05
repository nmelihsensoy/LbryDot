using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer.Abstract
{
    //Base class for repositories.
    //Every created repository class has to be derived from this class.
    //Purpose is generalizing database access for repositories.
    internal abstract class RepositoryBase
    {
        protected IDbTransaction dbTransaction { get; private set; }
        protected IDbConnection dbConnection { get { return dbTransaction.Connection; } }

        public RepositoryBase(IDbTransaction _dbTransaction)
        {
            dbTransaction = _dbTransaction;
        }

    }
}
