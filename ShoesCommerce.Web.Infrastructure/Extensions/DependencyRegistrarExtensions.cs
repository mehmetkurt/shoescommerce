using Microsoft.Extensions.DependencyInjection;
using ShoesCommerce.Data.Repositories;
using ShoesCommerce.Data.Services.Categories;
using ShoesCommerce.Model.Factories.Categories;
using ShoesCommerce.Model.Factories.Products;

namespace ShoesCommerce.Web.Infrastructure.Extensions;
public static class DependencyRegistrarExtensions
{
    public static void RegisterCommonDependencies(this IServiceCollection services)
    {
        services.AddTransient(typeof(IRepository<,>), typeof(Repository<,>));

        services.AddTransient<ICategoryService, CategoryService>();
        services.AddTransient<ICategoryModelFactory, CategoryModelFactory>();
        services.AddTransient<IProductModelFactory, ProductModelFactory>();
    }
}
