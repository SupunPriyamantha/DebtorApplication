using BackEnd.Domain.Providers;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace BackEnd.Infrastructure.Persistence.Querying.Providers
{
    public class DbConnectionProvider : IDbConnectionProvider
    {
        private string _connectionString;

        public DbConnectionProvider(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString(ConnectionStrings.DefaultConnectionString);
        }

        public IDbConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
