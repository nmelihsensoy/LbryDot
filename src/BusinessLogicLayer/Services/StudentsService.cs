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

        public StudentModel LoginStudent(LoginModel Credential)
        {
            LoginValidator validator = new LoginValidator();
            ValidationResult results = validator.Validate(Credential);
            string allMessages = results.ToString("\n");

            if (!results.IsValid)
            {
                throw new Exception(allMessages);
            }

            return _appContext.getUoW().StudentsRepository.LoginStudent(Credential);
        }

        public void AddStudent(StudentModel Student)
        {
            var output = _appContext.getUoW().StudentsRepository.Add(Student);
            _appContext.getUoW().Commit();

            StudentsValidator validator = new StudentsValidator();
            ValidationResult results = validator.Validate(Student);
            string allMessages = results.ToString("\n");

            if (!results.IsValid)
            {
                throw new Exception(allMessages);
            }

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
            
        }

    }
}
