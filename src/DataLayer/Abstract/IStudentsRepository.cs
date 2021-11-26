using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Abstract
{
    public interface IStudentsRepository : IGenericRepository<StudentModel>
    {
        StudentModel LoginStudent(LoginModel Credential);
    }
}
