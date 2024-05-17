using BackEnd.Domain.Providers;
using Dapper;

namespace BackEnd.Infrastructure.Persistence.Querying
{
    public abstract class BaseQuery
    {
        private readonly IDbConnectionProvider _connectionProvider;

        public BaseQuery(IDbConnectionProvider connectionProvider)
        {
            _connectionProvider = connectionProvider;
        }

        protected virtual async Task<T> QueryFirstOrDefaultAsync<T>(string sql, object param, CancellationToken cancellationToken)
        {
            using var connection = _connectionProvider.GetConnection();
            connection.Open();
            T result = await connection.QueryFirstOrDefaultAsync<T>(sql, param);
            return result;
        }
    }
}
