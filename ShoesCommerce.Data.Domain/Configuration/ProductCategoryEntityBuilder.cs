using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShoesCommerce.Data.Domain.Configuration;
public class ProductCategoryEntityBuilder : IEntityTypeConfiguration<ProductCategory>
{
    public void Configure(EntityTypeBuilder<ProductCategory> builder)
    {
        builder.ToTable("ProductCategory_Mapping");

        builder.HasKey(p => new { p.ProductId, p.CategoryId });

        builder.HasOne(p => p.Product)
            .WithMany(p => p.ProductCategories)
            .HasForeignKey(p => p.ProductId)
            .IsRequired();

        builder.HasOne(p => p.Category)
            .WithMany(p => p.ProductCategories)
            .HasForeignKey(p => p.CategoryId)
            .IsRequired();

        builder.Property(p => p.DisplayOrder).HasDefaultValue(0);
        builder.Ignore(p => p.Id);
    }
}
