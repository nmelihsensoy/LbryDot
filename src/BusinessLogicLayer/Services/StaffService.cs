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
    public class StaffService : Abstract.ServiceBase
    {
        public StaffService(CustomAppContext appContext) : base(appContext)
        {
        }

        private void ApplyMd5Hashing(ref LoginModel Model)
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

        public StaffModel LoginStaff(LoginModel Credential)
        {
            LoginValidator validator = new LoginValidator();
            ValidationResult results = validator.Validate(Credential);
            string allMessages = results.ToString("\n");

            if (!results.IsValid)
            {
                throw new Exception(allMessages);
            }

            ApplyMd5Hashing(ref Credential);
            return _appContext.getUoW().StaffRepository.LoginStaff(Credential);
        }

    }
}
