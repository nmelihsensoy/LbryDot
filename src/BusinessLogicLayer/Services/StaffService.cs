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

        public StaffModel LoginStaff(LoginModel Credential)
        {
            LoginValidator validator = new LoginValidator();
            ValidationResult results = validator.Validate(Credential);
            string allMessages = results.ToString("\n");

            if (!results.IsValid)
            {
                throw new Exception(allMessages);
            }

            return _appContext.getUoW().StaffRepository.LoginStaff(Credential);
        }

    }
}
