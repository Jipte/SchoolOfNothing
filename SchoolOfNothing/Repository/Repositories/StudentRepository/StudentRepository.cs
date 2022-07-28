using Canducci.SqlKata.Dapper.Extensions.Builder;
using Canducci.SqlKata.Dapper.Postgres;
using Dapper;
using SchoolOfNothing.Models;
using SchoolOfNothing.repository.Infrastructure;
using SqlKata;
using SqlKata.Compilers;

namespace SchoolOfNothing.repository.Repositories.StudentRepository
{
    public class StudentRepository : IStudentRepository
    {
        private string[] columns = new string[]
        {
            $"id AS {nameof(StudentModel.Id)}",

            $"firstname AS {nameof(StudentModel.FirstName)}",

            $"lastname AS {nameof(StudentModel.LastName)}",

            $"birthdate AS {nameof(StudentModel.BirthDate)}",
        };
        
        private readonly IConnectionFactory _connectionFactory;

        public StudentRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        public async Task create(StudentModel model)
        {
            var data = new Dictionary<string, object>()
            {
                ["id"] = Guid.NewGuid(),
                ["firstname"] = model.FirstName,
                ["lastname"] = model.LastName,
                ["birthdate"] = model.BirthDate.ToUniversalTime(),
            };
            using var connection = _connectionFactory.GetConnection();

            var query = new Query("demographics.student");

            query.AsInsert(data);

            var sql = new PostgresCompiler().Compile(query);

            await connection.ExecuteAsync(sql.Sql, sql.NamedBindings);
        }

        public async Task<StudentModel> Read(Guid id)
        {
            var query = new Query("demographics.student");

            query.Select(columns);

            query.Where("id", id);

            var sql = new PostgresCompiler().Compile(query);

            using var connection = _connectionFactory.GetConnection();

            var students = await connection.QueryFirstAsync<StudentModel>(sql.Sql, sql.NamedBindings);

            return students;
        }

        public async Task<IList<StudentModel>> ReadAll()
        {
            var query = new Query("demographics.student");

            query.Select(columns);

            var sql = new PostgresCompiler().Compile(query);
            
            using var connection = _connectionFactory.GetConnection();

            var students = await connection.QueryAsync<StudentModel>(sql.Sql);
            
            return students.ToList();
        }
    }
}
