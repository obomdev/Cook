using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cook.Models;

[Table("Receita")]
public class Receita
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Nome { get; set; }

    [Required]
    [StringLength(1000)]
    public string Descricao { get; set; }

    [StringLength(30)]
    public string TempoPreparo { get; set; }

    public int Rendimento { get; set; }

    public Dificuldade Dificuldade { get; set; }

    [StringLength(300)]
    public string Foto { get; set; }

    [Required]
    [StringLength(8000)]
    public string Preparo { get; set; }

    [Required]
    public int CategoriaId { get; set; }
    [ForeignKey("CategoriaId")]
    public Categoria Categoria { get; set; }

    public ICollection<ReceitaIngrediente> Ingredientes { get; set; }
}
