using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

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

    }
}
