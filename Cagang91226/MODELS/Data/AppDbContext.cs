using Cagang91226.MODELS.Domain;
using Microsoft.EntityFrameworkCore;

namespace Cagang91226.MODELS.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Product> Product => Set<Product>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
