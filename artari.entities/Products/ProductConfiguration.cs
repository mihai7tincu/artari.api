using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace artari.entities.Products
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(name: nameof(Product), schema: ArtariDbContext.Schema);
            builder.HasKey(x => x.Id);

            //builder.HasData(Seed.Data.GetProducts());
        }
    }
}

