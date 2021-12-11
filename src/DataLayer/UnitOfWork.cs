using DataLayer.Abstract;
using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private IDbConnection _dbConnection;
        private IDbTransaction _dbTransaction;
        private ISettingsRepository _settingsRepository;
        private IStaffRepository _staffRepository;
        private IStudentsRepository _studentsRepository;
        private IBooksRepository _booksRepository;
        private IBorrowingRepository _borrowingRepository;

        public UnitOfWork(IDatabaseProvider dbProvider)
        {   
            _dbConnection = dbProvider.ObtainConnection();
            _dbConnection.Open();
            _dbTransaction = _dbConnection.BeginTransaction();
        }

        public ISettingsRepository SettingsRepository
        {
            get { return _settingsRepository ?? (_settingsRepository = new SettingsRepository(_dbTransaction)); }
        }

        public IStaffRepository StaffRepository
        {
            get { return _staffRepository ?? (_staffRepository = new StaffRepository(_dbTransaction)); }
        }

        public IStudentsRepository StudentsRepository
        {
            get { return _studentsRepository ?? (_studentsRepository = new StudentsRepository(_dbTransaction)); }
        }

        public IBooksRepository BooksRepository
        {
            get { return _booksRepository ?? (_booksRepository = new BooksRepository(_dbTransaction)); }
        }

        public IBorrowingRepository BorrowingRepository
        {
            get { return _borrowingRepository ?? (_borrowingRepository = new BorrowingRepository(_dbTransaction)); }
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
            _settingsRepository = null;
            _staffRepository = null;
            _studentsRepository = null;
            _booksRepository = null;
            _borrowingRepository = null;
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
