using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Abstract
{
    public interface IBooksRepository : IGenericRepository<BookModel>
    {
        int[] AvailableBooks();
        short GetBookAvailability(int Id);
        int ChangeBookAvailability(int Id, short IsAvailable);
        IEnumerable<BookModel> Search(string Text);
        IEnumerable<String> GetAllCategories();
        IEnumerable<StatModel> GetFullChartData();
        int DelistBook(BookModel Model, DateTime DelistDate);
    }
}
