using BackEnd.Domain.Models.Debtors;
using BackEnd.Domain.Models.Debtors.Queries;
using MediatR;

namespace BackEnd.Application.Handlers.Debtors.Queries.Details
{
    public class GetDebtorDetailsQueryHandler : IRequestHandler<GetDebtorDetailsQuery, BaseResponse>
    {
        private readonly IDebtorQuery _debtorQuery;

        public GetDebtorDetailsQueryHandler(IDebtorQuery debtorQuery)
        {
            _debtorQuery = debtorQuery;
        }
        public async Task<BaseResponse> Handle(GetDebtorDetailsQuery query, CancellationToken cancellationToken)
        {
            DebtorQueryItem debtorQueryItem = await _debtorQuery.GetDebtor(query.SSN, cancellationToken);

            if (debtorQueryItem == null)
            {
                return new NotFoundResponse();
            }

            return new GetDebtorDetailsQueryResponse(debtorQueryItem);
        }
    }
}
