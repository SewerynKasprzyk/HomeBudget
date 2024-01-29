using Database.Entities;
using System.Data.Entity;

namespace Database
{
    public class HomeManagementDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Balance> Balances { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Goal> Goals { get; set; }
        public HomeManagementDbContext() : base("Server=(localdb)\\mssqllocaldb;Database=HomeBudgetManagement;Trusted_Connection=True; PersistSecurityInfo=True")
        {
                
        }
    }
}
