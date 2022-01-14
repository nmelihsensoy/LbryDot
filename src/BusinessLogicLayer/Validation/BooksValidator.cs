using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Validation
{
    public class BooksValidator : AbstractValidator<BookModel>
    {
        public BooksValidator()
        {
            RuleFor(x => x.title).NotEmpty().MinimumLength(4);
            RuleFor(x => x.isbn).NotEmpty().Matches(@"^\d{13}$");
            RuleFor(x => x.author).NotEmpty().MinimumLength(4).Matches(@"^(([A-Za-zÇçĞğİıÖöŞşÜü])+[\.]?[\ -\.]?){1,5}\.?([^\s-])+");
            RuleFor(x => x.date_of_publication).NotNull().InclusiveBetween(1000, DateTime.Today.AddYears(+1).Year);
            RuleFor(x => x.category).NotEmpty().Length(6, 50).Matches(@"^(([A-Za-zÇçĞğİıÖöŞşÜü])+[\.]?[\ -\.]?){1,2}\.?([^\s-])+");
            RuleFor(x => x.language).NotEmpty().Length(4, 15).Matches(@"^([^\s\d]+){1}");
            RuleFor(x => x.number_of_pages).NotEmpty().InclusiveBetween(0, 9999);
            RuleFor(x => x.shelf_number).NotEmpty().Length(1,4);
        }
    }
}
