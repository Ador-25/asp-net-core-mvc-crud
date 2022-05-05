using BankTransactions.Models;
using Microsoft.EntityFrameworkCore;


namespace BankTransactions.Contexts
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
