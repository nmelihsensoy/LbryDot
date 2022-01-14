using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Abstract
{
    public interface IBorrowingRepository : IGenericRepository<BorrowingModel>
    {
        int Borrow(BorrowingModel model);
        IEnumerable<BorrowingModel> GetAllJoined(int StudentNumber);
        IEnumerable<BorrowingModel> GetActives(int StudentNumber, int FirstRowCount);
        int GetTotalFineForStudent(int StudentId);
        int GetActiveFineForStudent(int StudentId);
        int ReturnBorrow(BorrowingModel Borrowing);
        Dictionary<DateTime, int[]> GetBorrowingStats(int LastDayCount = 5);
        IEnumerable<BorrowingModel> GetAllBorrowingsForBook(int BookId);
        int GetActiveBorrowingCountForStudent(int StudentId);
        IEnumerable<BorrowingModel> GetAllBorrowingsForStudent(int StudentId);
        IEnumerable<StatModel> GetFullChartData();
        int UpdateBook(int Id, int NewId=1);
        int UpdateStudent(int Id, int NewId=1);
    }
}
