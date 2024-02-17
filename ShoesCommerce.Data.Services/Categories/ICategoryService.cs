using ShoesCommerce.Data.Domain;

namespace ShoesCommerce.Data.Services.Categories;
public interface ICategoryService
{
    Category Insert(Category category);
    Category GetCategoryById(Guid id);
}
