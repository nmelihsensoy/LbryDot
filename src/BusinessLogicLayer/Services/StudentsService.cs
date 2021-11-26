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

    }
}
