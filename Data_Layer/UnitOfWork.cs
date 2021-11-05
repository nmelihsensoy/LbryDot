using Data_Layer.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public class UnitOfWork : IUnitOfWork
    {
        private IDbConnection _dbConnection;
        private IDbTransaction _dbTransaction;

        public UnitOfWork(IDatabaseProvider dbProvider)
        {
            _dbConnection = dbProvider.ObtainConnection();
            _dbConnection.Open();
            _dbTransaction = _dbConnection.BeginTransaction();
        }

        public void Commit()
        {
            try
            {
                _dbTransaction.Commit();
            }
            catch
            {
                _dbTransaction.Rollback(); //Rollback if any exception of the occured problem throwed. 
                throw;
            }
            finally
            {
                _dbTransaction.Dispose();
                _dbTransaction = _dbConnection.BeginTransaction();
                resetRepositories();
            }
        }

        private void resetRepositories()
        {
            
        }

        //Dispose Implementation
        //To making sure of any instance will be released.

        private bool _disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _dbTransaction?.Dispose(); //dispose if doesn't null
                    _dbConnection?.Dispose(); //dispose if doesn't null
                }
            }
            _disposedValue = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }
    }
}
