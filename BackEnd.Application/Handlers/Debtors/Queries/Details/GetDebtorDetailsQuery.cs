using MediatR;

namespace BackEnd.Application.Handlers.Debtors.Queries.Details
{
    public class GetDebtorDetailsQuery : IRequest<BaseResponse>
    {
        public string SSN { get; set; }
    }
}
