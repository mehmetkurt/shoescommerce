using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShoesCommerce.Data;

namespace ShoesCommerce.Web.Infrastructure.Extensions;
public static class ServiceCollectionExtensions
{
    public static void AddShoesCommerceDataContext(this IServiceCollection services,
        IConfiguration configuration,
        string connectionStringName)
    {
        services.AddDbContext<ShoesCommerceDbContext>(options =>
        {
            var connectionString = configuration.GetConnectionString(connectionStringName);
            options.UseSqlServer(connectionString,
                b => b.MigrationsAssembly("ShoesCommerce"));
        });
    }

    public static IMvcBuilder AddShoesCommerceMvc(this IServiceCollection services)
    {
        var builder = services.AddControllersWithViews();

        return builder;
    }


    public static IMvcBuilder AddShoesCommerceMvc(this IServiceCollection services, Action<MvcOptions>? configure)
    {
        var builder = services.AddControllersWithViews(configure);
        return builder;
    }
}
