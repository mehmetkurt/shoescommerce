namespace ShoesCommerce.Core.Abstraction;
public interface IDeletableEntity
{
    bool Deleted { get; set; }
    Guid? DeletedUserId { get; set; }
    DateTime? DeletedDate { get; set; }
}
