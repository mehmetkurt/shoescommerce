using System.Globalization;
using Microsoft.AspNetCore.Mvc;

namespace ShoesCommerce.Controllers;

public class CommonController : Controller
{
    //[Route("ChangeLanguage/{lang}")]
    public IActionResult ChangeLanguage(string lang)
    {
        var cultureInfo = new CultureInfo(lang);
        CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
        CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

        return RedirectToAction("Index", "Home");
    }
}