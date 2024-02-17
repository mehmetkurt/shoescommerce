using Microsoft.AspNetCore.Mvc;
using ShoesCommerce.Model.Factories.Categories;

namespace ShoesCommerce.Controllers;

public class HomeController : Controller
{
    private readonly ICategoryModelFactory _categoryModelFactory;
    public HomeController(ICategoryModelFactory categoryModelFactory)
    {
        _categoryModelFactory = categoryModelFactory;
    }
    public IActionResult Index() {

        _categoryModelFactory.GetCategoryViewModels();
        return View();
    }
}