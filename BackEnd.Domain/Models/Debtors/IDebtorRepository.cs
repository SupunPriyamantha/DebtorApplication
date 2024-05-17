namespace BackEnd.Domain.Models.Debtors
{
    public interface IDebtorRepository
    {
        Task<Debtor> Get(int id);

        Task<IEnumerable<Debtor>> GetAll();

        Task Add(Debtor customer);

        Task Delete(int id);

        Task Update(Debtor customer);
    }
}
