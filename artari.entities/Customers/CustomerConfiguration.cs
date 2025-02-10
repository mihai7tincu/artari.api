using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace artari.entities.Customers
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable(name: nameof(Customer), schema: ArtariDbContext.Schema);
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Phone).HasMaxLength(32).IsRequired();
            builder.Property(x => x.Address).HasMaxLength(128).IsRequired();
            builder.HasIndex(x => x.Phone).IsUnique();
        }
    }
}
