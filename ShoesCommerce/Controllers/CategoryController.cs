using Microsoft.AspNetCore.Mvc;

namespace ShoesCommerce.Controllers;

public class CategoryController : Controller
{
    public IActionResult Index() {
        return View();
    }
}