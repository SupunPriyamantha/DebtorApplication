using BackEnd.Domain.Models.Debtors;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace BackEnd.Infrastructure.Persistence
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Debtor> Debtors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Debtors
            modelBuilder.Entity<Debtor>().HasData(new Debtor
            {
                DebtorId = 1,
                SSN = "424-11-9327",
                FirstName = "Supun",
                LastName = "Priyamantha",
                Address = "09 Westend Terrace",
                AssessedIncome = 60668,
                BalanceOfDebt = 11585,
                Complaints = true

            });
            modelBuilder.Entity<Debtor>().HasData(new Debtor
            {
                DebtorId = 2,
                SSN = "424-11-9323",
                FirstName = "Sandun",
                LastName = "Lasantha",
                Address = "04 Eastend Terrace",
                AssessedIncome = 78968,
                BalanceOfDebt = 11543,
                Complaints = true
            });
            modelBuilder.Entity<Debtor>().HasData(new Debtor
            {
                DebtorId = 3,
                SSN = "424-11-4717",
                FirstName = "Kasun",
                LastName = "Shanaka",
                Address = "04 North London",
                AssessedIncome = 85245,
                BalanceOfDebt = 10258,
                Complaints = false
            });
            modelBuilder.Entity<Debtor>().HasData(new Debtor
            {
                DebtorId = 4,
                SSN = "424-12-7896",
                FirstName = "Roy",
                LastName = "Dias",
                Address = "04 North Wellington",
                AssessedIncome = 96587,
                BalanceOfDebt = 20147,
                Complaints = true
            });
        }
    }
}
