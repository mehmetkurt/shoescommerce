using ShoesCommerce.Data.Services.Categories;
using ShoesCommerce.Models;

namespace ShoesCommerce.Model.Factories.Products;
public class ProductModelFactory : IProductModelFactory
{
    private readonly ICategoryService _categoryService;
    public ProductModelFactory(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    public List<ProductViewModel> GetProductViewModels(int? categoryId = null)
    {
        return [];
    }
}
