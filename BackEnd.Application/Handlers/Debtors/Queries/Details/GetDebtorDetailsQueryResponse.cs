using BackEnd.Domain.Models.Debtors.Queries;
using Microsoft.AspNetCore.Http;

namespace BackEnd.Application.Handlers.Debtors.Queries.Details
{
    public class GetDebtorDetailsQueryResponse : BaseResponse
    {
        public GetDebtorDetailsQueryResponse(DebtorQueryItem debtor)
            : base(StatusCodes.Status200OK)
        {
            Debtor = debtor;
        }

        public DebtorQueryItem Debtor { get; private set; }
    }
}
