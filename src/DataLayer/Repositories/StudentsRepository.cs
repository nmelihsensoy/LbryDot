using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    internal class StudentsRepository : Abstract.RepositoryBase, Abstract.IStudentsRepository
    {
        public StudentsRepository(IDbTransaction dbTransaction) : base(dbTransaction)
        {
        }

        public int Add(StudentModel model)
        {
            throw new NotImplementedException();
        }

        public int Delete(StudentModel model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StudentModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public StudentModel GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(StudentModel model)
        {
            throw new NotImplementedException();
        }
    }
}
