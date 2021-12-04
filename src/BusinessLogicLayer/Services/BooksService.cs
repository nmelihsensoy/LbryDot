using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using BusinessLogicLayer.Validation;
using FluentValidation.Results;

namespace BusinessLogicLayer.Services
{
    public class BooksService : Abstract.ServiceBase
    {
        public BooksService(CustomAppContext appContext) : base(appContext)
        {
        }

        public BookModel GetBookById(int Id)
        {
            var output = _appContext.getUoW().BooksRepository.GetById(Id);
            _appContext.getUoW().Commit();

            return output;
        }

        public void AddBook(BookModel Book)
        {
            var output = _appContext.getUoW().BooksRepository.Add(Book);
            _appContext.getUoW().Commit();

            BooksValidator validator = new BooksValidator();
            ValidationResult results = validator.Validate(Book);
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

        public List<BookModel> GetAllBooks()
        {
            var output = _appContext.getUoW().BooksRepository.GetAll().ToList();
            _appContext.getUoW().Commit();

            return output;
        }

    }
}
