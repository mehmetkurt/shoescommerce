using Microsoft.AspNetCore.Mvc;

namespace ShoesCommerce;

public class HomeController : Controller
{
    public IActionResult Index() {
        return View();
    }
}