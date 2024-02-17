using ShoesCommerce.Core.Abstraction;
using System.ComponentModel;

namespace ShoesCommerce.Data.Domain;
public class ProductCategory : BaseEntity<Guid>, IOrderableEntity
{
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    private new Guid Id { get; set; }

    public Guid ProductId { get; set; }
    public Guid CategoryId { get; set; }
    public int DisplayOrder { get; set; }

    #region NavigationProperties
    public virtual Category Category { get; set; }
    public virtual Product Product { get; set; }
    #endregion
}
