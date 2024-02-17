using ShoesCommerce.Data.Domain;
using ShoesCommerce.Data.Services.Categories;
using ShoesCommerce.Models;

namespace ShoesCommerce.Model.Factories.Categories;
public class CategoryModelFactory : ICategoryModelFactory
{
    private readonly ICategoryService _categoryService;
    public CategoryModelFactory(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }


    public List<CategoryViewModel> GetCategoryViewModels()
    {
        var res = _categoryService.GetCategoryById(new Guid("9314E418-D367-4E20-7B49-08DC2FC58E5C"));
        //_categoryService.Insert(new Category
        //{
        //    ParentId = 0,
        //    Title = "Bilgisayarlar",
        //    Description = null
        //});
        return [];
    }
}
