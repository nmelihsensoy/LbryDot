using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Abstract
{
    //Most used basic operations for models. Used with implementing this interface in the repositories own class.
    //Other operations that not defined here can be defined in the repositories own interface. 
    public interface IGenericRepository<T>
    {
        int Add(T model);
        int Update(T model);
        int Delete(T model);
        IEnumerable<T> GetAll();
        T GetById(int Id);
    }
}
