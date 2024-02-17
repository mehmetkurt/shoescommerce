using ShoesCommerce.Core.Abstraction;

namespace ShoesCommerce.Data.Domain;
public class Product : BaseEntity<Guid>,
    IOrderableEntity,
    IPublishableEntity,
    IDeletableEntity,
    IHasCreated,
    IHasUpdated
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal? OldPrice { get; set; }
    public decimal? SpecialPrice { get; set; }
    public DateTime? SpecialPriceStartDate { get; set; }
    public DateTime? SpecialPriceEndDate { get; set; }

    public int DisplayOrder { get; set; }
    public bool Published { get; set; }
    public bool Deleted { get; set; }
    public Guid? DeletedUserId { get; set; }
    public DateTime? DeletedDate { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }

    #region Navigation Properties
    public virtual ICollection<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();
    #endregion
}
