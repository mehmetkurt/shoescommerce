using Microsoft.AspNetCore.Mvc.Rendering;

namespace ShoesCommerce.Models;

public class CreateCategoryModel
{
    public int SelectedParentId { get; set; } = 0;
    public string Title { get; set; }
    public List<SelectListItem> AvailableCategories { get; set; } = [];
}
