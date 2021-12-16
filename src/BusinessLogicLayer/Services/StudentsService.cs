using BusinessLogicLayer.Validation;
using Entities;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class StudentsService : Abstract.ServiceBase
    {
        public StudentsService(CustomAppContext appContext) : base(appContext)
        {
        }

        private void ApplyMd5Hashing(ref LoginModel Model)
        {
            if (!String.IsNullOrEmpty(Model.Password))
            {
                Model.Password = Helpers.MD5Hash(Model.Password, Helpers.GetEncryptionConfig());
            }
        }

        private void ApplyMd5Hashing(LoginModel Model)
        {
            if (!String.IsNullOrEmpty(Model.Password))
            {
                Model.Password = Helpers.MD5Hash(Model.Password, Helpers.GetEncryptionConfig());
            }
        }

        private void ApplyMd5Hashing(ref StudentModel Model)
        {
            if (!String.IsNullOrEmpty(Model.student_password))
            {
                Model.student_password = Helpers.MD5Hash(Model.student_password, Helpers.GetEncryptionConfig());
            }
        }

        private void ApplyMd5Hashing(StudentModel Model)
        {
            if (!String.IsNullOrEmpty(Model.student_password))
            {
                Model.student_password = Helpers.MD5Hash(Model.student_password, Helpers.GetEncryptionConfig());
            }
        }

        public StudentModel LoginStudent(LoginModel Credential)
        {
            LoginValidator validator = new LoginValidator();
            ValidationResult results = validator.Validate(Credential);
            string allMessages = results.ToString("\n");

            if (!results.IsValid)
            {
                throw new Exception(allMessages);
            }

            ApplyMd5Hashing(ref Credential);
            return _appContext.getUoW().StudentsRepository.LoginStudent(Credential);
        }

        public void AddStudent(StudentModel Student)
        {
            StudentsValidator validator = new StudentsValidator();
            ValidationResult results = validator.Validate(Student);
            string allMessages = results.ToString("\n");

            if (!results.IsValid)
            {
                throw new Exception(allMessages);
            }

            ApplyMd5Hashing(ref Student);
            var output = _appContext.getUoW().StudentsRepository.Add(Student);
            _appContext.getUoW().Commit();

            if (output != 1)
            {
                throw new Exception("Error");
            }
        }

        public List<Object> GetAllStudents()
        {
            var output = _appContext.getUoW().StudentsRepository.GetAll().Select(x => new { Student_Number = x.student_number, Student_Name = x.student_name, Student_Email = x.student_email }).ToList<Object>();
            _appContext.getUoW().Commit();

            return output;
        }

        public List<Object> SearchStudent(String SearchText)
        {
            var output = _appContext.getUoW().StudentsRepository.Search(SearchText).Select(x => new { Student_Number = x.student_number, Student_Name = x.student_name, Student_Email = x.student_email }).ToList<Object>();
            _appContext.getUoW().Commit();

            return output;
        }

        public StudentModel GetStudentById(int Id)
        {
            var output = _appContext.getUoW().StudentsRepository.GetById(Id);
            output.student_password = "";
            _appContext.getUoW().Commit();

            return output;
        }

        public void DeleteStudentById(int Id)
        {
            StudentModel TempStudent = new StudentModel();
            TempStudent.student_number = Id;
            var output = _appContext.getUoW().StudentsRepository.Delete(TempStudent);
            _appContext.getUoW().Commit();
        }

        public void UpdateStudent(StudentModel Student)
        {
            ApplyMd5Hashing(ref Student);
            var output = _appContext.getUoW().StudentsRepository.Update(Student);
            _appContext.getUoW().Commit();
        }

        public void BulkAdd(List<StudentModel> Students)
        {
            foreach (var Student in Students)
            {
                ApplyMd5Hashing(Student);
                var output = _appContext.getUoW().StudentsRepository.Add(Student);
                if (output == -1)
                {
                    break;
                }
            }
            _appContext.getUoW().Commit();
        }

    }
}
