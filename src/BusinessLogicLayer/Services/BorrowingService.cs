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
        public enum BorrowState
        {
            Error = -1,
            Borrowed = 0,
            Late = 1,
            TwoDaysLeft = 2,
            Returned = 3
        }

        public BorrowingService(CustomAppContext appContext) : base(appContext)
        {
        }

        public static BorrowState GetBorrowState(BorrowingModel Borrowing, out int DayDiff)
        {
            return GetBorrowState(Borrowing.returned_date, Borrowing.due_date, out DayDiff);
        }

        public static BorrowState GetBorrowState(DateTime ReturnedDate, DateTime DueDate, out int DayDiff)
        {
            DayDiff = -1;
            if (ReturnedDate == DateTime.MinValue)
            {
                DayDiff = Helpers.DaysBetween(DueDate, DateTime.Today);
                if (DayDiff < 1)
                {
                    if (DayDiff == -2)
                    {
                        return BorrowState.TwoDaysLeft;
                    }
                    else
                    {
                        return BorrowState.Borrowed;
                    }
                }
                else
                {
                    return BorrowState.Late;
                }
            }
            else
            {
                DayDiff = Helpers.DaysBetween(ReturnedDate, DateTime.Today);
                return BorrowState.Returned;
            }
        }

        public void BorrowBook(BorrowingModel Borrowing)
        {
            BorrowValidator validator = new BorrowValidator();
            ValidationResult results = validator.Validate(Borrowing);
            string allMessages = results.ToString("\n");

            if (!results.IsValid)
            {
                throw new Exception(allMessages);
            }

            var output = _appContext.getUoW().BorrowingRepository.Borrow(Borrowing);
            var output2 = _appContext.getUoW().BooksRepository.ChangeBookAvailability(Borrowing.book.book_id, 0);
            _appContext.getUoW().Commit();

            if (output != 1 || output2 !=1)
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
                Borrowing.amount_of_fine = DayCount * _appContext.AppSettings.daily_fine_amount;
            }
            else
            {
                Borrowing.amount_of_fine = 0;
            }

            return Borrowing;

        }

        public void ReturnBook(BorrowingModel Borrowing)
        {
            ReturnValidator validator = new ReturnValidator();
            ValidationResult results = validator.Validate(Borrowing);
            string allMessages = results.ToString("\n");

            if (!results.IsValid)
            {
                throw new Exception(allMessages);
            }

            var output = _appContext.getUoW().BorrowingRepository.ReturnBorrow(Borrowing);
            var output2 = _appContext.getUoW().BooksRepository.ChangeBookAvailability(Borrowing.book.book_id, 1);
            _appContext.getUoW().Commit();

            if (output != 1 || output2 != 1)
            {
                throw new Exception("Error");
            }
        }

        public int GetChartData(out double[] Val1, out double[] Val2, out string[] Str, int DayCount = 5)
        {
            var output = _appContext.getUoW().BorrowingRepository.GetBorrowingStats(DayCount);
            _appContext.getUoW().Commit();

            Val1 = new double[DayCount];
            Val2 = new double[DayCount];
            Str = new string[DayCount];

            DateTime TmpDate = DateTime.Today.Date;
            for (int i = DayCount-1; i>-1; i--)
            {
                Str[i] = TmpDate.ToString("dd/MM/yyyy");
                if (output.ContainsKey(TmpDate))
                {
                    //output.Add(TmpDate, new int[] { 0, 0 });
                    Val1[i] = (output[TmpDate] as int[])[0];
                    Val2[i] = (output[TmpDate] as int[])[1];
                }
                else
                {
                    Val2[i] = 0;
                    Val2[i] = 0;
                }
                TmpDate = TmpDate.AddDays(-1);
            }
            return 1;
        }

        public List<Object> GetBorrowingsForBook(int BookId)
        {
            var output = _appContext.getUoW().BorrowingRepository.GetAllBorrowingsForBook(BookId).Select(x => new { Student_Name = x.student.student_name, Borrow_Date = x.issued_date.Date, Returned_Date = x.returned_date.Date, Due_Date = x.due_date.Date }).ToList<Object>();
            _appContext.getUoW().Commit();

            return output;
        }

        public List<Object> GetBorrowingsForBook(int BookId, bool IsCensored, string CensorException=null)
        {
            var output = _appContext.getUoW().BorrowingRepository.GetAllBorrowingsForBook(BookId).Select(x => new { Student_Name = x.student.student_name.Equals(CensorException) ? x.student.student_name : Helpers.HideWords(x.student.student_name), Borrow_Date = x.issued_date.Date, Returned_Date = x.returned_date, Due_Date = x.due_date.Date }).ToList<Object>();
            _appContext.getUoW().Commit();

            return output;
        }
        public List<Object> GetBorrowingsForStudent(int StudentId)
        {
            var output = _appContext.getUoW().BorrowingRepository.GetAllBorrowingsForStudent(StudentId).Select(x => new { Book_Name = x.book.title, Borrow_Date = x.issued_date, Returned_Date = x.returned_date, Due_Date = x.due_date.Date }).ToList<Object>();
            _appContext.getUoW().Commit();

            return output;
        }

        public void BulkAdd(List<BorrowingModel> Borrowings)
        {
            foreach (var Borrow in Borrowings)
            {
                var output = _appContext.getUoW().BorrowingRepository.Add(Borrow);
                if (output == -1)
                {
                    break;
                }
            }
            _appContext.getUoW().Commit();
        }

        public List<StatModel> GetFullChartData()
        {
            var output = _appContext.getUoW().BorrowingRepository.GetFullChartData().ToList<StatModel>();
            _appContext.getUoW().Commit();

            return output;
        }
    }
}
