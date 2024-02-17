using Microsoft.EntityFrameworkCore;

using ShoesCommerce.Data.Domain;
using ShoesCommerce.Data.Domain.Configuration;

namespace ShoesCommerce.Data;

public class ShoesCommerceDbContext : DbContext
{
    public ShoesCommerceDbContext(DbContextOptions<ShoesCommerceDbContext> options) : base(options)
    {
        
    }

    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryEntityBuilder).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}
