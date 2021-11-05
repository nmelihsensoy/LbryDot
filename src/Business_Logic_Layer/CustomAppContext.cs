using Data_Layer;
using Data_Layer.Abstract;
using Data_Layer.DatabaseProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer
{
    //Used for creating database instance and creating unit of work with this database instance.
    //Provides unit of work access for services.
    //Every different type of presentation has to create its own CustomAppContext and share it through every service instance want to use.
    //Also can be used for transfering the app context between the pages in presentation that use services.
    public class CustomAppContext
    {
        private static IDatabaseProvider dbConn;
        protected IUnitOfWork _unitOfWork { get; }

        public CustomAppContext()
        {
            dbConn = new DatabaseProvider();
            _unitOfWork = new UnitOfWork(dbConn);
        }

        public IUnitOfWork getUoW()
        {
            return _unitOfWork;
        }
    }
}
