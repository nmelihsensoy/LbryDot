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

        public int[] GetAvailableCount()
        {
            var output = _appContext.getUoW().BooksRepository.AvailableBooks();
            _appContext.getUoW().Commit();

            if(output.Length != 2 && output[0] == -1 && output[1] == -1)
            {
                throw new Exception("Value Error");
            }
            return output;
        }

        public void UpdateBook(BookModel Book)
        {
            var output = _appContext.getUoW().BooksRepository.Update(Book);
            _appContext.getUoW().Commit();
        }

        public List<BookModel> SearchBook(String SearchText)
        {
            var output = _appContext.getUoW().BooksRepository.Search(SearchText).ToList();
            _appContext.getUoW().Commit();

            return output;
        }

        public void DeleteBook(BookModel Book)
        {
            var output = _appContext.getUoW().BooksRepository.Delete(Book);
            _appContext.getUoW().Commit();
        }

        public List<CategoryModel> GetCategoriesList()
        {
            //var output = _appContext.getUoW().BooksRepository.GetAllCategories().ToList<Object>();
            var output = _appContext.getUoW().BooksRepository.GetAllCategories().Select(x => new CategoryModel{ CategoryRaw = x, CategoryName = Helpers.GetOnlyText(x), CategoryColor = Helpers.PaddedStringToColor(x, System.Drawing.Color.Empty) }).ToList<CategoryModel>();
            _appContext.getUoW().Commit();

            return output;
        }

        public void BulkAdd(List<BookModel> Books)
        {
            foreach (var Book in Books)
            {
                var output = _appContext.getUoW().BooksRepository.Add(Book);
                if (output == -1)
                {
                    break;
                }
            }
            _appContext.getUoW().Commit();
        }

        public List<StatModel> GetBookChartData()
        {
            var output = _appContext.getUoW().BooksRepository.GetFullChartData().ToList<StatModel>();
            _appContext.getUoW().Commit();

            return output;
        }

    }
}
