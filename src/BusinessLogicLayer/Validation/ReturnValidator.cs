using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Validation
{
    public class ReturnValidator : AbstractValidator<BorrowingModel>
    {
        public ReturnValidator()
        {
            RuleFor(x => x.returned_date.Date).Equal(DateTime.Today.Date);
        }
    }
}
