using BackEnd.Domain.Models.Debtors;

namespace BackEnd.Infrastructure.Persistence.Repositories
{
    public class DebtorRepository : IDebtorRepository
    {
        public Task Add(Debtor customer)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Debtor> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Debtor>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Update(Debtor customer)
        {
            throw new NotImplementedException();
        }
    }
}
