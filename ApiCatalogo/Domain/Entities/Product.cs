using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCatalogo.Domain.Entities;

[Table("Products")]
public class Product
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(300)]
    public string? Name { get; set; }

    [Required]
    [StringLength(300)]
    public string? Description { get; set; }

    [Required]
    [Column(TypeName = "decimal(10,2)")]
    public decimal Price { get; set; }
    public float Stock { get; set; }

    [Required]
    [StringLength(300)]
    public string? ImageUrl { get; set; }
    public DateTime CreatedOn { get; set; }
    public int CategoryId { get; set; } // mapear chave estrangeira
    public Category? Category { get; set; } // cada produto esta mapeado para uma categoria
}
