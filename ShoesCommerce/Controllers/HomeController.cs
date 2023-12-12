using Microsoft.AspNetCore.Mvc;

namespace ShoesCommerce.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() {
        return View();
    }
}