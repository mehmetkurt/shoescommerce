using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShoesCommerce.Data;
using ShoesCommerce.Models;

namespace ShoesCommerce.Components;

public class NavigationViewComponent : ViewComponent
{
    private readonly ShoesCommerceDbContext _context;
    public NavigationViewComponent(ShoesCommerceDbContext context)
    {
        _context = context;
    }

    public IViewComponentResult Invoke()
    {
        var query = _context.Categories
            .Where(p => p.Published)
            .OrderBy(p => p.DisplayOrder);

        var sqlQuery = query.ToQueryString();
        
        var categories = query.ToList();
        var model = categories.Select(p =>
        {
            return new CategoryViewModel
            {
                Id = p.Id,
                ParentId = p.ParentId,
                Title = p.Title,
                AlternateText = p.AlternateText
            };
        }).ToList();

        return View(model);
    }
}
