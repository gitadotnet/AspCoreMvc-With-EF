using Microsoft.EntityFrameworkCore;

namespace AspCoreMvcWithEF_CRUD_BankTransaction02.Models
{
    public class TransactionDbContext: DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options)
        { }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
