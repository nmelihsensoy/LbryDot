using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstract
{
    public abstract class ServiceBase
    {
        protected CustomAppContext _appContext;

        public ServiceBase(CustomAppContext appContext)
        {
            _appContext = appContext;
        }
    }
}
