using Microsoft.AspNetCore.Mvc;

namespace ShoesCommerce.Controllers;

public class CategoryController : Controller
{
    
    public IActionResult Index()
    {
        return RedirectToRoute("CategoryDetail", new { id = 0 });
    }

    public IActionResult List(int id)
    {
        if (id == 0)
            return RedirectToRoute("default");

        return View(id);
    }
}