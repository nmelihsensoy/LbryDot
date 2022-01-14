using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Validation
{
    public class StaffValidator : AbstractValidator<StaffModel>
    {
        public StaffValidator()
        {
            RuleFor(x => x.staff_email).NotEmpty().EmailAddress();
            RuleFor(x => x.staff_name).NotEmpty().MinimumLength(4).Matches(@"^(([A-Za-zÇçĞğİıÖöŞşÜü])+[\.]?[\ -\.]?){1,}\.?([^\s-])+");
        }
    }
}
