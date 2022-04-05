using Microsoft.EntityFrameworkCore;
using ThosCafeMenu.Entity;

namespace ThosCafeMenu.Data
{
    public class dbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Database=THOSCAFEMENUDB;Integrated Security=True;");
        }
        public DbSet<Category> CATEGORY { get; set; }
        public DbSet<Product> PRODUCT { get; set; } 
        public DbSet<User> USER { get; set; } 
    }
}