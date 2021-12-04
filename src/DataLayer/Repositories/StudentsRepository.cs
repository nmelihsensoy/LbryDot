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
            throw new NotImplementedException();
        }

        public IEnumerable<StudentModel> GetAll()
        {
            return dbConnection.Query<StudentModel>("SELECT * FROM Students",
                new DynamicParameters(),
                transaction: dbTransaction);
        }

        public IEnumerable<StudentModel> Search(string Text)
        {
            return dbConnection.Query<StudentModel>("SELECT * FROM Students WHERE student_name LIKE @text OR student_email LIKE @text OR student_number LIKE @text;",
                new { text = "%" + Text + "%" },
                transaction: dbTransaction);
        }

        public StudentModel GetById(int Id)
        {
            return dbConnection.Query<StudentModel>("SELECT * FROM Students WHERE student_number = @id;", new { id = Id }, transaction: dbTransaction).FirstOrDefault();
        }

        public void Update(StudentModel model)
        {
            throw new NotImplementedException();
        }

        public StudentModel LoginStudent(LoginModel Credential)
        {
            DynamicParameters parameter = new DynamicParameters();
            parameter.Add("@email", Credential.Email, DbType.String, ParameterDirection.Input);
            parameter.Add("@pass", Credential.Password, DbType.String, ParameterDirection.Input);
            var output = dbConnection.Query<StudentModel>("SELECT * FROM Students WHERE student_email = @email AND student_password = @pass;",
                                                                            parameter, transaction: dbTransaction).FirstOrDefault();

            if (output == null)
            {
                throw new Exception("User Not Found");
            }


            return output;
        }

    }
}
