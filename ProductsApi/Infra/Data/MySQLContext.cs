using Microsoft.EntityFrameworkCore;
using ProductsApi.Domain.Model;

namespace ProductsApi.Infra.Data
{
    public class MySQLContext: DbContext
    {
        public DbSet<Product> Products { get; set; }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
        }
    }
}
