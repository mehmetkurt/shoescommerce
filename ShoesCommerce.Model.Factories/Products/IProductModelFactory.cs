using ShoesCommerce.Models;

namespace ShoesCommerce.Model.Factories.Products;
public interface IProductModelFactory
{
    List<ProductViewModel> GetProductViewModels(int? categoryId = default);
}
