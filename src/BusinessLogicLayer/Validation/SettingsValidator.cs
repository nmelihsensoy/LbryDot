using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Validation
{
    public class SettingsValidator : AbstractValidator<SettingsModel>
    {
        public SettingsValidator()
        {
            RuleFor(x => x.currency_symbol).NotEmpty().Length(1, 4);
            RuleFor(x => x.daily_fine_amount).NotNull().LessThan(100);
        }
    }
}
