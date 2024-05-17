namespace BackEnd.Domain.Models.Debtors.Queries
{
    public class DebtorQueryItem
    {
        public DebtorQueryItem(
            int debtorId,
            string ssn,
            string firstName,
            string lastName,
            string address,
            int assessedIncome,
            int balanceOfDebt,
            bool complaints)
        {
            DebtorId = debtorId;
            SSN = ssn;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            AssessedIncome = assessedIncome;
            BalanceOfDebt = balanceOfDebt;
            Complaints = complaints;
        }

        public int DebtorId { get; }

        public string SSN { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public string Address { get; }

        public int AssessedIncome { get; }

        public int BalanceOfDebt { get; }

        public bool Complaints { get; }
    }
}
