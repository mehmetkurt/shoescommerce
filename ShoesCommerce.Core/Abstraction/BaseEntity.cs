using System.ComponentModel.DataAnnotations;

namespace ShoesCommerce.Core.Abstraction;
public abstract class BaseEntity<T> : IBaseEntity<T>
    where T : struct
{
    [Key]
    public virtual T Id { get; set; }
}
