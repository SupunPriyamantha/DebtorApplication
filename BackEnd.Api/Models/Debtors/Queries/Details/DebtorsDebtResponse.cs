namespace BackEnd.Api.Models.Debtors.Queries.Details
{
    public class DebtorsDebtResponse : BaseResponse
    {
        public int BalanceOfDebt { get; set; }

        public bool Complaints { get; set; }
    }
}
