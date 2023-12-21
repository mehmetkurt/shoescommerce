using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoesCommerce.Data.Domain;

public class Category
{
    public int Id { get; set; }
    public int ParentId { get; set; }

    [Required]
    [MaxLength(30)]
    public string Title { get; set; }

    [Required]
    [MaxLength(128)]
    public string AlternateText { get; set; }
    
    public int? DisplayOrder { get; set; }
    public bool Published { get; set; }

    [Column(TypeName ="datetime")]
    public DateTime CreatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime UpdatedDate { get; set; }
}
