using BackEnd.Application.Handlers.Debtors.Queries.Details;
using BackEnd.Domain.Models.Debtors;
using BackEnd.Domain.Models.Debtors.Queries;
using FluentAssertions;
using Moq;
using System.ComponentModel;
using System.Net;

namespace BackEnd.Application.Test.Handlers
{
    public class GetDebtorDetailsQueryHandlerTest
    {
        private readonly GetDebtorDetailsQueryHandler _handler;

        private readonly Mock<IDebtorQuery> _debtorQuery;
        private readonly Debtor _debtor;

        public GetDebtorDetailsQueryHandlerTest()
        {
            _debtorQuery = new Mock<IDebtorQuery>();
            _debtor = new Debtor()
            {
                DebtorId = 4,
                SSN = "424-12-7896",
                FirstName = "Roy",
                LastName = "Dias",
                Address = "04 North Wellington",
                AssessedIncome = 96587,
                BalanceOfDebt = 20147,
                Complaints = true
            };

            _debtorQuery.Setup(s => s.GetDebtor(It.IsAny<string>(), default))
                .ReturnsAsync((string ssn, CancellationToken token) => (_debtor.SSN == ssn) ? BuildDebtorQueryItem(_debtor) : null);

            _handler = new GetDebtorDetailsQueryHandler(_debtorQuery.Object);
        }

        [Fact]
        [Category("Application")]
        public async Task Handle_GivenValidInput_ReturnsResponseModel()
        {
            var query = new GetDebtorDetailsQuery
            {
                SSN = _debtor.SSN
            };

            var result = await _handler.Handle(query, default);
            result.Should().BeOfType<GetDebtorDetailsQueryResponse>();
            result.StatusCode.Should().Be(200);
            (result as GetDebtorDetailsQueryResponse).Debtor.SSN.Should().Be("424-12-7896");
            (result as GetDebtorDetailsQueryResponse).Debtor.FirstName.Should().Be("Roy");
        }

        public static DebtorQueryItem BuildDebtorQueryItem(Debtor debtor)
        {
            return new DebtorQueryItem(
                debtor.DebtorId,
                debtor.SSN,
                debtor.FirstName,
                debtor.LastName,
                debtor.Address,
                debtor.AssessedIncome,
                debtor.BalanceOfDebt,
                debtor.Complaints);
        }
    }
}
