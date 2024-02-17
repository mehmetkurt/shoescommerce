using Microsoft.AspNetCore.Mvc;
using ShoesCommerce.Model.Factories.Products;

namespace ShoesCommerce.Controllers;
public class TestController : Controller
{
    private readonly IProductModelFactory _productModelFactory;
    public TestController(IProductModelFactory productModelFactory)
    {
        _productModelFactory = productModelFactory;
    }

    public IActionResult Index()
    {
       var models = _productModelFactory.GetProductViewModels();
        return View(models);
    }
}
