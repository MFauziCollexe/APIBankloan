using Microsoft.EntityFrameworkCore;

namespace APIBankLoan.Models
{
    public class BankLoanContext : DbContext
    {
        public BankLoanContext(DbContextOptions<BankLoanContext> options) : base(options)
        {

        }
        public DbSet<BisInfoDetail> bisInfoDetails { get; set; }
        public DbSet<authorizers> Authorizers { get; set; }
    }
}