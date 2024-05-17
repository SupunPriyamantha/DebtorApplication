using BackEnd.Domain.Models.Debtors;
using BackEnd.Domain.Models.Debtors.Queries;
using BackEnd.Domain.Providers;

namespace BackEnd.Infrastructure.Persistence.Querying.Queries
{
    public class DebtorQuery : BaseQuery, IDebtorQuery
    {
        public DebtorQuery(IDbConnectionProvider connectionProvider) : base(connectionProvider)
        {
        }

        public async Task<DebtorQueryItem> GetDebtor(string sss, CancellationToken cancellationToken)
        {
            return await QueryFirstOrDefaultAsync<DebtorQueryItem>(
                $@"
                SELECT 
                    ""DebtorId"", 
                    ""SSN"", 
                    ""FirstName"",
                    ""LastName"",
                    ""Address"", 
                    ""AssessedIncome"",
                    ""BalanceOfDebt"",
                    ""Complaints""
                FROM 
                    ""Debtors"" 
                WHERE 
                    ""SSN"" = @sss"
                , new { sss },
                cancellationToken);
        }
    }
}
