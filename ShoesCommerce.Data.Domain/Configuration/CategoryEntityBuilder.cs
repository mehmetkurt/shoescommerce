using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShoesCommerce.Data.Domain.Configuration;
public class CategoryEntityBuilder : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable(nameof(Category));
        builder.HasKey(p => p.Id);

        builder
            .Property(p => p.ParentId)
            .HasDefaultValue(0);

        builder
            .Property(p => p.Title)
            .HasMaxLength(32)
            .IsRequired();

        builder.Property(p => p.Description);

        builder.Property(p => p.DisplayOrder).HasDefaultValue(0);
        builder.Property(p => p.Published).HasDefaultValue(true);

        builder.Property(p => p.CreatedDate)
            .HasColumnType("datetime")
            .HasDefaultValueSql("getdate()");

        builder.Property(p => p.UpdatedDate)
            .HasColumnType("datetime")
            .HasDefaultValueSql("getdate()");
    }
}
