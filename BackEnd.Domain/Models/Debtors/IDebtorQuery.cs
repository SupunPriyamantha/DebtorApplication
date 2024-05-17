using BackEnd.Domain.Models.Debtors.Queries;

namespace BackEnd.Domain.Models.Debtors
{
    public interface IDebtorQuery
    {
        Task<DebtorQueryItem> GetDebtor(string sss, CancellationToken cancellationToken);
    }
}
