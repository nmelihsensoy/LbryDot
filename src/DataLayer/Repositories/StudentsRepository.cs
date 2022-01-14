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
    internal class StudentsRepository : Abstract.RepositoryBase, Abstract.IStudentsRepository
    {
        public StudentsRepository(IDbTransaction dbTransaction) : base(dbTransaction)
        {
        }

        public int Add(StudentModel model)
        {
            return dbConnection.Execute("INSERT INTO Students (student_email, student_password, student_name, student_avatar) values (@student_email, @student_password, @student_name, @student_avatar)",
                model,
                transaction: dbTransaction);
        }

        public int Delete(StudentModel model)
        {
            return dbConnection.Execute("DELETE FROM Students WHERE student_number>1 AND student_number=@id", new { id = model.student_number }, dbTransaction);
        }
        
        public IEnumerable<StudentModel> GetAll()
        {
            return dbConnection.Query<StudentModel>("SELECT * FROM Students WHERE student_number>1",
                new DynamicParameters(),
                transaction: dbTransaction);
        }

        public IEnumerable<StudentModel> Search(string Text)
        {
            return dbConnection.Query<StudentModel>("SELECT * FROM Students WHERE student_number>1 AND student_name LIKE @text OR student_email LIKE @text OR student_number LIKE @text;",
                new { text = "%" + Text + "%" },
                transaction: dbTransaction);
        }

        public StudentModel GetById(int Id)
        {
            return dbConnection.Query<StudentModel>("SELECT * FROM Students WHERE student_number>1 AND student_number = @id;", new { id = Id }, transaction: dbTransaction).FirstOrDefault();
        }

        public int Update(StudentModel model)
        {
            if (String.IsNullOrEmpty(model.student_password))
            {
                return dbConnection.Execute("UPDATE Students SET student_email=@student_email, student_name=@student_name, student_avatar=@student_avatar WHERE student_number>1 AND student_number = @student_number;", model,
                transaction: dbTransaction);
            }
            else {
                return dbConnection.Execute("UPDATE Students SET student_email=@student_email, student_password=@student_password, student_name=@student_name, student_avatar=@student_avatar WHERE student_number>1 AND student_number = @student_number;", model,
                transaction: dbTransaction);
            }
            
        }

        public StudentModel LoginStudent(LoginModel Credential)
        {
            DynamicParameters parameter = new DynamicParameters();
            parameter.Add("@email", Credential.Email, DbType.String, ParameterDirection.Input);
            parameter.Add("@pass", Credential.Password, DbType.String, ParameterDirection.Input);
            var output = dbConnection.Query<StudentModel>("SELECT * FROM Students WHERE student_number>1 AND student_email = @email AND student_password = @pass;",
                                                                            parameter, transaction: dbTransaction).FirstOrDefault();

            if (output == null)
            {
                throw new Exception("User Not Found");
            }

            return output;
        }

        public int GetCount()
        {
            return dbConnection.Query<int>("SELECT COUNT(*) FROM Students WHERE student_number>1;", new DynamicParameters(), transaction: dbTransaction).Single();
        }

    }
}
