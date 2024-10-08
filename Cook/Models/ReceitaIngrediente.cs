using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cook.Models;

[Table("ReceitaIngrediente")]
public class ReceitaIngrediente
{
    [Key, Column(Order =1)]
    public int ReceitaId { get; set; }
    [ForeignKey("ReceitaId")]
    public Receita Receita { get; set; }
    
    [Key, Column(Order = 2)]
    public int IngredienteId { get; set; }
    [ForeignKey("IngredienteId")]
    public Ingrediente Ingrediente { get; set; }
    
    [Required]
    [StringLength(30)]
    public string Quantidade { get; set; }

    [StringLength(200)]
    public string Preparo { get; set; }
}
