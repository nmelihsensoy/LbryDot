using Dapper;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    internal class StaffRepository : Abstract.RepositoryBase, Abstract.IStaffRepository
    {
        public StaffRepository(IDbTransaction dbTransaction) : base(dbTransaction)
        {
        }

        public int Add(StaffModel model)
            {
                throw new NotImplementedException();
            }

        public int Delete(StaffModel model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StaffModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public StaffModel GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public int Update(StaffModel model)
        {
            throw new NotImplementedException();
        }

        public StaffModel LoginStaff(LoginModel Credential)
        {
            DynamicParameters parameter = new DynamicParameters();
            parameter.Add("@email", Credential.Email, DbType.String, ParameterDirection.Input);
            parameter.Add("@pass", Credential.Password, DbType.String, ParameterDirection.Input);
            var output = dbConnection.Query<StaffModel>("SELECT * FROM Staff WHERE staff_email = @email AND staff_password = @pass;", 
                                                                            parameter, transaction: dbTransaction).FirstOrDefault();

            if (output == null)
            {
                throw new Exception("User Not Found");
            }


            return output;
        }

    }
}
