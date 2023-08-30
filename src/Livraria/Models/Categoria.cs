using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Livraria.Models
{
    public class Categoria
    {
        [Key]
        [Column("categoria_id")]
        public int CategoriaId { get; set; }

        [Column("nome")]
        [Required]
        [MaxLength(30)]
        public string Nome { get; set; }
    }
}
