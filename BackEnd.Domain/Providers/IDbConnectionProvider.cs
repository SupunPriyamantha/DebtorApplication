using System.Data;

namespace BackEnd.Domain.Providers
{
    public interface IDbConnectionProvider
    {
        IDbConnection GetConnection();
    }
}
