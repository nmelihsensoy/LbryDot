using DataLayer;
using DataLayer.Abstract;
using DataLayer.DatabaseProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using BusinessLogicLayer.Services;

namespace BusinessLogicLayer
{
    //Used for creating database instance and creating unit of work instance with using this database instance.
    //Provides unit of work access for services.
    //Every different type of presentation(WinForms, Webui, API) has to create its own CustomAppContext and share it through every service instance want to use.
    //Also can be used for transfering the app context between the pages in presentation that use services.
    public class CustomAppContext
    {
        private static IDatabaseProvider dbConn;
        protected IUnitOfWork _unitOfWork { get; }
        private UserType LoggedUserType = UserType.Undefined;
        private StaffModel LoggedStaff = null;
        private StudentModel LoggedStudent = null;
        private SettingsModel _appSettings = null;

        public CustomAppContext()
        {
            dbConn = new DatabaseProvider();
            _unitOfWork = new UnitOfWork(dbConn);
            if (_appSettings == null)
            {
                UpdateSettings();
            }
        }

        public IUnitOfWork getUoW()
        {
            return _unitOfWork;
        }

        public SettingsModel AppSettings
        {
            get { return _appSettings; }
        }

        public void SetLoggedUser(StaffModel _loggedStaff)
        {
            if (_loggedStaff != null)
            {
                LoggedStaff = _loggedStaff;
                LoggedUserType = _loggedStaff.staff_type;
            }
        }

        public void SetLoggedUser(StudentModel _loggedStudent)
        {
            if (_loggedStudent != null)
            {
                LoggedStudent = _loggedStudent;
                LoggedUserType = UserType.Student;
            }
        }

        public UserType GetUserType()
        {
            return LoggedUserType;
        }

        public StaffModel GetLoggedStaff()
        {
            if (LoggedStaff != null)
                return LoggedStaff;
            else
                throw new Exception("There is no staff that logged in.");
        }

        public StudentModel GetLoggedStudent()
        {
            if (LoggedStudent != null)
                return LoggedStudent;
            else
                throw new Exception("There is no student that logged in.");
        }

        public void DbReset()
        {
            if(LoggedUserType == UserType.Admin)
            {
                getUoW().CloseConnection();
                dbConn.ResetDatabase();
            }
            else
            {
                throw new Exception("Only Admin can reset the database.");
            }
        }

        public void UpdateSettings()
        {
            _appSettings = getUoW().SettingsRepository.GetSettings();
        }

        public void UpdateUser()
        {
            if (this.GetUserType() == UserType.Student)
            {
                LoggedStudent = getUoW().StudentsRepository.GetById(LoggedStudent.student_number);
            }
            else if (this.GetUserType() == UserType.Undefined)
            {
                throw new Exception("An Error Occured");
            }
            else
            {
                LoggedStaff = getUoW().StaffRepository.GetById(LoggedStaff.staff_id);
            }
        }

        public void UpdateFine()
        {
            StudentsService.SetFineAmounts(this, ref LoggedStudent);
        }

    }
}
