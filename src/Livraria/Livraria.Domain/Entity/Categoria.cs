using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria.Domain.Entity;

public class Categoria
{
    [Key] [Column("categoria_id")] public int CategoriaId { get; set; }

    [Column("nome")]
    [Required]
    [MaxLength(30)]
    public string Nome { get; set; }
}