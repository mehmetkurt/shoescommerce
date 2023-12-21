using Microsoft.EntityFrameworkCore;
using ShoesCommerce.Data.Domain;

namespace ShoesCommerce.Data;

public class ShoesCommerceDbContext : DbContext
{
    public ShoesCommerceDbContext(DbContextOptions<ShoesCommerceDbContext> options) : base(options)
    {

    }

    public DbSet<Category> Categories { get; set; }
}
