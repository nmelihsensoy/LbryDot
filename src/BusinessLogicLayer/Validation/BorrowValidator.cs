using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Validation
{
    public class BorrowValidator : AbstractValidator<BorrowingModel>
    {
        public BorrowValidator()
        {
            RuleFor(x => x.due_date.Date).GreaterThanOrEqualTo(DateTime.Today.Date);
        }
    }
}
