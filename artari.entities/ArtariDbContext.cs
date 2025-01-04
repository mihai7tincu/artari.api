using artari.entities.Products;
using Microsoft.EntityFrameworkCore;

namespace artari.entities
{
    public class ArtariDbContext : DbContext
    {
        public const string Schema = "artari";
        public ArtariDbContext(DbContextOptions<ArtariDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(Schema);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ArtariDbContext).Assembly);
        }

        public DbSet<Product> Products { get; set; } = default!;
    }
}
