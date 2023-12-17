using eShop.Domain.Orders;
using eShop.Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShop.Persistence.Configurations;

public class LineItemConfiguration : IEntityTypeConfiguration<LineItem>
{
    public void Configure(EntityTypeBuilder<LineItem> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasConversion(
                id => id.Value,
                value => new LineItemId(value));

        builder
            .HasOne<Product>()
            .WithMany()
            .HasForeignKey(x => x.ProductId);

        builder.OwnsOne(x => x.Price);
    }
}