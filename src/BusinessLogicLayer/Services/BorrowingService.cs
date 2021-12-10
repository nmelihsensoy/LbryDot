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
            var output = _appContext.getUoW().BorrowingRepository.GetAllJoined(_appContext.GetLoggedStudent().student_number).ToList();
            _appContext.getUoW().Commit();

            return output;
        }

        public List<BorrowingModel> GetActives(int BorrowTopCount)
        {
            var output = _appContext.getUoW().BorrowingRepository.GetActives(_appContext.GetLoggedStudent().student_number, BorrowTopCount).ToList();
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

        public Tuple<double[], double[], string[]> GetChartData()
        {
            var output = _appContext.getUoW().BorrowingRepository.GetBorrowingStats();
            _appContext.getUoW().Commit();

            double[] y = new double[5];
            double[] y2 = new double[5];
            string[] str = new string[5];
            DateTime[] last5Day = new DateTime[5];

            last5Day[0] = DateTime.Today.AddDays(-4);
            str[0] = last5Day[0].ToString("dd/MM/yyyy");
            for (int i = 1; i < 5; i++)
            {
                last5Day[i] = last5Day[i - 1].AddDays(+1);
                str[i] = last5Day[i].ToString("dd/MM/yyyy");
            }

            foreach (var Day in output.Item1)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (last5Day[i].Date == Day.date.Date)
                    {
                        y[i] = Day.count;
                    }
                }
            }

            foreach (var Day in output.Item2)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (last5Day[i].Date == Day.date.Date)
                    {
                        y2[i] = Day.count;
                    }
                }
            }

            return Tuple.Create(y, y2, str);
        }

        public List<Object> GetBorrowingsForBook(int BookId)
        {
            var output = _appContext.getUoW().BorrowingRepository.GetAllBorrowingsForBook(BookId).Select(x => new { Student_Name = x.student.student_name, Borrow_Date = x.issued_date, Returned_Date = x.returned_date }).ToList<Object>(); ;
            _appContext.getUoW().Commit();

            return output;
        }

        public List<Object> GetBorrowingsForBook(int BookId, bool IsCensored)
        {
            var output = _appContext.getUoW().BorrowingRepository.GetAllBorrowingsForBook(BookId).Select(x => new { Student_Name = Helpers.HideWords(x.student.student_name), Borrow_Date = x.issued_date.Date, Returned_Date = x.returned_date }).ToList<Object>(); ;
            _appContext.getUoW().Commit();

            return output;
        }

    }
}
