using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Validation
{
    public class LoginValidator : AbstractValidator<LoginModel>
    {
        public LoginValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Email Empty")
                .MinimumLength(4)
                .WithMessage("Short Email")
                .EmailAddress().WithMessage("A valid email is required").Unless(IsAdmin);
            
            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Pass Empty")
                .MinimumLength(4)
                .WithMessage("Short Password");
        }

        private bool IsAdmin(LoginModel Model)
        {
            if (Model.Email == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}