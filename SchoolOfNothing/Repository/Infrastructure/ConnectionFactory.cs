using BuildingManager.Repository.IoC;
using Microsoft.Extensions.Options;
using Npgsql;
using System.Data;

namespace SchoolOfNothing.Repository.Infrastructure
{
    public class ConnectionFactory:IConnectionFactory
    {
        private readonly IOptions<RepositoryConfiguration>_ConnectionStrings;
        public ConnectionFactory(IOptions<RepositoryConfiguration> connectionStrings)
        {
            _ConnectionStrings = connectionStrings;
        }

        public IDbConnection GetConnection()
        {
            return new NpgsqlConnection(_ConnectionStrings.Value.ConnectionString);
        }
    }
}
