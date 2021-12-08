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
        IEnumerable<BorrowingModel> GetAllJoined(int StudentNumber);
        IEnumerable<BorrowingModel> GetActives(int StudentNumber, int FirstRowCount);
        int ReturnBorrow(BorrowingModel Borrowing);
        Tuple<List<StatModel>, List<StatModel>> GetBorrowingStats(int LastDayCount = 5);
        IEnumerable<BorrowingModel> GetAllBorrowingsForBook(int BookId);
    }
}
