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
    public class BorrowingService : Abstract.ServiceBase
    {
        public BorrowingService(CustomAppContext appContext) : base(appContext)
        {
        }

        public void AddBorrowing(BorrowingModel Borrowing)
        {
            var output = _appContext.getUoW().BorrowingRepository.Add(Borrowing);
            var output2 = _appContext.getUoW().BooksRepository.ChangeBookAvailability(Borrowing.book.book_id, 0);
            _appContext.getUoW().Commit();

            BorrowingValidator validator = new BorrowingValidator();
            ValidationResult results = validator.Validate(Borrowing);
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

        public List<BorrowingModel> GetAllBorrowings()
        {
            var output = _appContext.getUoW().BorrowingRepository.GetAllJoined(_appContext.GetLoggedStudent().student_number, 0).ToList();
            _appContext.getUoW().Commit();

            return output;
        }

        public List<BorrowingModel> GetAllBorrowings(int BorrowTopCount)
        {
            var output = _appContext.getUoW().BorrowingRepository.GetAllJoined(_appContext.GetLoggedStudent().student_number, BorrowTopCount).ToList();
            _appContext.getUoW().Commit();

            return output;
        }

        public BorrowingModel CalculateFee(BorrowingModel Borrowing)
        {
            Borrowing.returned_date = DateTime.Today;
            int DayCount = Helpers.DaysBetween(Borrowing.due_date, Borrowing.returned_date);

            if (DayCount > 0)
            {
                SettingsModel Settings = _appContext.getUoW().SettingsRepository.GetSettings();
                _appContext.getUoW().Commit();
                Borrowing.amount_of_fine = DayCount * Settings.daily_fine_amount;
            }
            else
            {
                Borrowing.amount_of_fine = 0;
            }

            return Borrowing;

        }

        public void ReturnBook(BorrowingModel Borrowing)
        {
            var output = _appContext.getUoW().BorrowingRepository.ReturnBorrow(Borrowing);
            var output2 = _appContext.getUoW().BooksRepository.ChangeBookAvailability(Borrowing.book.book_id, 1);
            _appContext.getUoW().Commit();

            BorrowingValidator validator = new BorrowingValidator();
            ValidationResult results = validator.Validate(Borrowing);
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
    }
}
