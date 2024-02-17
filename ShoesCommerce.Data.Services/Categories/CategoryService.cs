using ShoesCommerce.Data.Repositories;
using ShoesCommerce.Data.Domain;
using Microsoft.EntityFrameworkCore;

namespace ShoesCommerce.Data.Services.Categories;
public class CategoryService : ICategoryService
{
    private readonly IRepository<Category, Guid> _categoryRepository;
    private readonly IRepository<ProductCategory, Guid> _productCategoryRepository;

    public CategoryService
    (
        IRepository<Category, Guid> categoryRepository,
        IRepository<ProductCategory, Guid> productCategoryRepository
    )
    {
        _categoryRepository = categoryRepository;
        _productCategoryRepository = productCategoryRepository;
    }

    public Category GetCategoryById(Guid id)
    {
        var categoryTable = _categoryRepository.Table;
        var productCategoryTable = _productCategoryRepository.Table;

        var query = from c in categoryTable
                    join pc in productCategoryTable
                    on c.Id equals pc.CategoryId
                    select c;

        query = query.Where(p => p.Published);

        query = query.Where(p => p.CreatedDate > DateTime.Now.AddDays(-31));


        var qs = query.ToQueryString();
        return _categoryRepository.GetById(id);
        //return _dbContext.Categories.Find(id);
    }

    public Category Insert(Category category)
    {
        return _categoryRepository.Insert(category);
    }
}
