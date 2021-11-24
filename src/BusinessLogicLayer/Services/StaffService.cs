using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    class StaffService : Abstract.ServiceBase
    {
        public StaffService(CustomAppContext appContext) : base(appContext)
        {
        }
    }
}
