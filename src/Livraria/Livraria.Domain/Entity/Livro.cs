using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria.Domain.Entity;

public class Livro
{
    [Key] [Column("livro_id")] public int LivroId { get; set; }

    [Column("titulo")]
    [Required]
    [MaxLength(100)]
    public string Titulo { get; set; }

    [Column("isbn")]
    [Required]
    [MaxLength(20)]
    public string ISBN { get; set; }

    [Column("data_publicacao")] public DateTime? DataPublicacao { get; set; }

    [Column("preco")]
    [Required]
    [Range(0, double.MaxValue)]
    public decimal Preco { get; set; }

    [Column("quantidade_estoque")]
    [Required]
    [Range(0, int.MaxValue)]
    public int QuantidadeEstoque { get; set; }

    [Column("autor_id")] [Required] public int AutorId { get; set; }

    [Column("categoria_id")] [Required] public int CategoriaId { get; set; }

    [ForeignKey("AutorId")] public Autor Autor { get; set; }

    [ForeignKey("CategoriaId")] public Categoria Categoria { get; set; }
}