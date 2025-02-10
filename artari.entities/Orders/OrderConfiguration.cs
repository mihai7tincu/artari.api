using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace artari.entities.Orders
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable(name: nameof(Order), schema: ArtariDbContext.Schema);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.OrderNumber).IsRequired();
            
            builder.HasOne(x => x.Customer).WithMany(x => x.Orders).HasForeignKey(x => x.CustomerId);
        }
    }
}
