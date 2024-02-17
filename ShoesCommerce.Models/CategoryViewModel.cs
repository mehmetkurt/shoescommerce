namespace ShoesCommerce.Models;

public class CategoryViewModel
{
    public int Id { get; set; }
    public int ParentId { get; set; }
    public string Title { get; set; }
    public string AlternateText { get; set; }
}
