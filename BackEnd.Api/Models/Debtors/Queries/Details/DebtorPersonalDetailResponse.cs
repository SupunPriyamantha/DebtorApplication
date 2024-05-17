namespace BackEnd.Api.Models.Debtors.Queries.Details
{
    public class DebtorPersonalDetailResponse : BaseResponse
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }
    }
}
