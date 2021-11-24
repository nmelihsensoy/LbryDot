using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    class BooksService : Abstract.ServiceBase
    {
        public BooksService(CustomAppContext appContext) : base(appContext)
        {
        }
    }
}
