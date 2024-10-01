using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cook.Models;

[Table("Comentario")]
public class Comentario
{
    [Required]
    public int Id { get; set; } 

    [Required]
    public string UsuarioId { get; set; }
    [ForeignKey("UsuarioId")]
    public Usuario Usuario { get; set; }

    [Required]
    public int ReceitaId { get; set; }
    [ForeignKey("ReceitaId")]
    public Receita Receita { get; set; }

    public DateTime DataCometario { get; set; } = DateTime.Now;

    [StringLength(300)]
    public string TextoComentario { get; set; }
}
