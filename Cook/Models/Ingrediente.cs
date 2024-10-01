using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cook.Models;

[Table("Ingrediente")]
public class Ingrediente
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Nome { get; set; }

    public ICollection<ReceitaIngrediente> Receitas { get; set; }
}
