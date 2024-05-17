using AutoMapper;

namespace BackEnd.Api.Models.Debtors
{
    public class DebtorAutoMapperProfile : Profile
    {
        public DebtorAutoMapperProfile()
        {
            CreateMap<Application.Handlers.Debtors.Queries.Details.GetDebtorDetailsQueryResponse, Queries.Details.DebtorPersonalDetailResponse>()
                .ForMember(dest => dest.FirstName, opts => opts.MapFrom(src => src.Debtor.FirstName))
                .ForMember(dest => dest.LastName, opts => opts.MapFrom(src => src.Debtor.LastName))
                .ForMember(dest => dest.Address, opts => opts.MapFrom(src => src.Debtor.Address))
                .IncludeBase<Application.Handlers.BaseResponse, BaseResponse>();

            CreateMap<Application.Handlers.Debtors.Queries.Details.GetDebtorDetailsQueryResponse, Queries.Details.DebtorAssessedIncomeResponse>()
                .ForMember(dest => dest.AssessedIncome, opts => opts.MapFrom(src => src.Debtor.AssessedIncome))
                .IncludeBase<Application.Handlers.BaseResponse, BaseResponse>();

            CreateMap<Application.Handlers.Debtors.Queries.Details.GetDebtorDetailsQueryResponse, Queries.Details.DebtorsDebtResponse>()
                .ForMember(dest => dest.BalanceOfDebt, opts => opts.MapFrom(src => src.Debtor.BalanceOfDebt))
                .ForMember(dest => dest.Complaints, opts => opts.MapFrom(src => src.Debtor.Complaints))
                .IncludeBase<Application.Handlers.BaseResponse, BaseResponse>();
        }
    }
}
