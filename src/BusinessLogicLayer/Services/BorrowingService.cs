using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    class BorrowingService : Abstract.ServiceBase
    {
        public BorrowingService(CustomAppContext appContext) : base(appContext)
        {
        }
    }
}
