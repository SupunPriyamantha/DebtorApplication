using BackEnd.Domain.Models.Debtors;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Infrastructure.Persistence
{
    public interface IAppDbContext
    {
        DbSet<Debtor> Debtors { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
