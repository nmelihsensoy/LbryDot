using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Validation
{
    public class StudentsValidator : AbstractValidator<StudentModel>
    {
        public StudentsValidator()
        {
            RuleFor(x => x.student_email).NotEmpty().EmailAddress();
            RuleFor(x => x.student_name).NotEmpty().MinimumLength(4).Matches(@"^(([A-Za-zÇçĞğİıÖöŞşÜü])+[\.]?[\ -\.]?){1,}\.?([^\s-])+");
        }
    }
}
