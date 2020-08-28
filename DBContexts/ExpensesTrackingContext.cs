using ExpensesTrackingSystem.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExpensesTrackingSystem.API.DbContexts
{
    public class ExpensesTrackingContext : DbContext
    {
        public ExpensesTrackingContext()
        {

        }
        public ExpensesTrackingContext(DbContextOptions<ExpensesTrackingContext> options)
      : base(options)
        { }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Users> Users { get; set; }

        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Expense> Expenses { get; set; }       
    }
}
