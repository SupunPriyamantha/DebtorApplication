namespace BackEnd.Domain.Models.Debtors
{
    public class Debtor
    {
        public int DebtorId { get; set; }

        public string SSN { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public int AssessedIncome { get; set; }

        public int BalanceOfDebt { get; set; }

        public bool Complaints { get; set; }
    }
}
