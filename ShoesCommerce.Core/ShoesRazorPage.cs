using System.Globalization;
using Microsoft.AspNetCore.Mvc.Razor;

namespace ShoesCommerce.Core;


public abstract class ShoesRazorPage<TModel> : RazorPage<TModel>
{
    public CultureInfo CurrentLanguage => CultureInfo.DefaultThreadCurrentCulture ?? new CultureInfo("en-US");
}

public abstract class ShoesRazorPage : ShoesRazorPage<dynamic>
{
}
