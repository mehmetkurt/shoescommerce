using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShoesCommerce.Data.Domain.Configuration;
public class ProductEntityBuilder : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable(nameof(Product));

        builder
            .Property(p => p.Name)
            .HasMaxLength(128)
            .IsRequired();

        builder.Property(p => p.Price)
            .HasPrecision(25, 2)
            .IsRequired();

        builder.Property(p => p.OldPrice)
            .HasPrecision(25, 2)
            .IsRequired(false);

        builder.Property(p => p.SpecialPrice)
            .HasPrecision(25, 2)
            .IsRequired(false);

        builder.Property(p => p.SpecialPriceStartDate)
            .HasColumnType("datetime")
            .HasDefaultValueSql("getdate()");

        builder.Property(p => p.SpecialPriceEndDate)
            .HasColumnType("datetime")
            .HasDefaultValueSql("getdate()");

        builder.Property(p => p.DisplayOrder).HasDefaultValue(0);
        builder.Property(p => p.Published).HasDefaultValue(true);
        builder.Property(p => p.Deleted).HasDefaultValue(false);

        builder.Property(p => p.DeletedUserId)
            .IsRequired();
        
        builder.Property(p => p.DeletedDate)
            .HasColumnType("datetime")
            .HasDefaultValueSql("getdate()");

        builder.Property(p => p.CreatedDate)
            .HasColumnType("datetime")
            .HasDefaultValueSql("getdate()");

        builder.Property(p => p.UpdatedDate)
            .HasColumnType("datetime")
            .HasDefaultValueSql("getdate()");
    }
}
