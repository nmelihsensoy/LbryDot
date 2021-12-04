using DataLayer;
using DataLayer.Abstract;
using DataLayer.DatabaseProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BusinessLogicLayer
{
    //Used for creating database instance and creating unit of work with this database instance.
    //Provides unit of work access for services.
    //Every different type of presentation has to create its own CustomAppContext and share it through every service instance want to use.
    //Also can be used for transfering the app context between the pages in presentation that use services.
    public class CustomAppContext
    {
        private static IDatabaseProvider dbConn;
        protected IUnitOfWork _unitOfWork { get; }
        private short LoggedUserType = -1;
        StaffModel LoggedStaff = null;
        StudentModel LoggedStudent = null;

        public CustomAppContext()
        {
            dbConn = new DatabaseProvider();
            _unitOfWork = new UnitOfWork(dbConn);
        }

        public IUnitOfWork getUoW()
        {
            return _unitOfWork;
        }

        public void SetLoggedUser(StaffModel _loggedStaff = null, StudentModel _loggedStudent = null)
        {
            LoggedStaff = _loggedStaff;
            LoggedStudent = _loggedStudent;

            if (_loggedStaff != null && _loggedStudent == null)
            {
                LoggedUserType = 1;
            }
            else if (_loggedStaff == null && _loggedStudent != null)
            {
                LoggedUserType = 2;
            }
            else
            {
                LoggedUserType = -1;
            }
        }

        public short GetUserType()
        {
            return LoggedUserType;
        }

        public StaffModel GetLoggedStaff()
        {
            return LoggedStaff;
        }

        public StudentModel GetLoggedStudent()
        {
            return LoggedStudent;
        }
    }
}
