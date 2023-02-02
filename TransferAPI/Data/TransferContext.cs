using Microsoft.EntityFrameworkCore;
using TransferAPI.Models;

namespace TransferAPI.Data
{
    public class TransferContext : DbContext
    {
        public TransferContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

    }
}
