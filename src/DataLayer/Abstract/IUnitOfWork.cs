using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        //To let UnitOfWork Coordinate repositories, all repositories has to be added here
        void Commit();
    }
}
