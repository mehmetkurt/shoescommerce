using ShoesCommerce.Models;

namespace ShoesCommerce.Model.Factories.Categories;
public interface ICategoryModelFactory
{
    List<CategoryViewModel> GetCategoryViewModels();
}
