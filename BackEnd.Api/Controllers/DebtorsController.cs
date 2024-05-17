using Asp.Versioning;
using AutoMapper;
using BackEnd.Api.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace BackEnd.Api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/credit-data")]
    [ApiController]
    public class DebtorsController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public DebtorsController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpGet("personal-details/{ssn}")]
        public async Task<IActionResult> GetDebtorPersonalDetails(string ssn, CancellationToken cancellationToken)
        {
            var applicationQuery = new Application.Handlers.Debtors.Queries.Details.GetDebtorDetailsQuery() { SSN = ssn };
            var applicationResult = await _mediator.Send(applicationQuery, cancellationToken);

            BaseResponse result = (BaseResponse)_mapper.Map(applicationResult, applicationResult.GetType(), typeof(Models.Debtors.Queries.Details.DebtorPersonalDetailResponse));

            return ToActionResult(result);
        }

        [HttpGet("assessed-income/{ssn}")]
        public async Task<IActionResult> GetDebtorAssessedIncome(string ssn, CancellationToken cancellationToken)
        {
            var applicationQuery = new Application.Handlers.Debtors.Queries.Details.GetDebtorDetailsQuery() { SSN = ssn };
            var applicationResult = await _mediator.Send(applicationQuery, cancellationToken);

            BaseResponse result = (BaseResponse)_mapper.Map(applicationResult, applicationResult.GetType(), typeof(Models.Debtors.Queries.Details.DebtorAssessedIncomeResponse));

            return ToActionResult(result);
        }

        [HttpGet("debt/{ssn}")]
        public async Task<IActionResult> GetDebtorDebtDetails(string ssn, CancellationToken cancellationToken)
        {
            var applicationQuery = new Application.Handlers.Debtors.Queries.Details.GetDebtorDetailsQuery() { SSN = ssn };
            var applicationResult = await _mediator.Send(applicationQuery, cancellationToken);

            BaseResponse result = (BaseResponse)_mapper.Map(applicationResult, applicationResult.GetType(), typeof(Models.Debtors.Queries.Details.DebtorsDebtResponse));

            return ToActionResult(result);
        }
    }
}
