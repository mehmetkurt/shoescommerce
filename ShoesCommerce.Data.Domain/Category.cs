using ShoesCommerce.Core.Abstraction;

namespace ShoesCommerce.Data.Domain;

public class Category : BaseEntity<Guid>,
    IOrderableEntity,
    IPublishableEntity,
    IHasCreated,
    IHasUpdated
{
    public int ParentId { get; set; }
    public string Title { get; set; }
    public string? Description { get; set; }
    public int DisplayOrder { get; set; }
    public bool Published { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

    #region Navigation Properties
    public virtual ICollection<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();
    #endregion
}
