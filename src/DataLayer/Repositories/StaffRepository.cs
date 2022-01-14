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
            return dbConnection.Execute("INSERT INTO Staff (staff_email, staff_name, staff_password, staff_avatar) values (@staff_email, @staff_name, @staff_password, @staff_avatar)",
                model,
                transaction: dbTransaction);
        }

        public int Delete(StaffModel model)
        {
            return dbConnection.Execute("DELETE FROM Staff WHERE staff_id=@id", new { id = model.staff_id }, dbTransaction);
        }

        public IEnumerable<StaffModel> GetAll()
        {
            return dbConnection.Query<StaffModel>("SELECT * FROM Staff",
                new DynamicParameters(),
                transaction: dbTransaction);
        }

        public IEnumerable<StaffModel> GetAllWithoutAdmin()
        {
            return dbConnection.Query<StaffModel>("SELECT * FROM Staff WHERE staff_type IS NOT 0",
                new DynamicParameters(),
                transaction: dbTransaction);
        }

        public StaffModel GetById(int Id)
        {
            return dbConnection.Query<StaffModel>("SELECT * FROM Staff WHERE staff_id = @id;", new { id = Id }, transaction: dbTransaction).FirstOrDefault();
        }

        public int Update(StaffModel model)
        {
            if (String.IsNullOrEmpty(model.staff_password))
            {
                return dbConnection.Execute("UPDATE Staff SET staff_email=@staff_email, staff_name=@staff_name, staff_avatar=@staff_avatar WHERE staff_id = @staff_id;", model,
                transaction: dbTransaction);
            }
            else
            {
                return dbConnection.Execute("UPDATE Staff SET staff_email=@staff_email, staff_password=@staff_password, staff_name=@staff_name, staff_avatar=@staff_avatar WHERE staff_id = @staff_id;", model,
                transaction: dbTransaction);
            }
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

        public int GetCount()
        {
            return dbConnection.Query<int>("SELECT COUNT(*) FROM Staff WHERE staff_id>1;", new DynamicParameters(), transaction: dbTransaction).Single();
        }
    }
}
