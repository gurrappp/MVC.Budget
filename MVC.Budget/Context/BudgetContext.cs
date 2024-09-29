using Microsoft.EntityFrameworkCore;
using MVC.Budget.Models;

namespace MVC.Budget.Context
{
    public class BudgetContext : DbContext
    {
        public BudgetContext(DbContextOptions<BudgetContext> options) : base(options) 
        {
        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
