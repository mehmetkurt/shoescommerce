using Microsoft.AspNetCore.Mvc;

namespace ShoesCommerce;

public class CategoryController : Controller
{
    public IActionResult Index() {
        return View();
    }
}