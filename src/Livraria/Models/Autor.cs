using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Livraria.Models
{
    public class Autor
    {
        [Column("autor_id")]
        public int AutorId { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("data_nascimento")]
        public DateTime? DataNascimento { get; set; }

        [Column("nacionalidade")]
        public string Nacionalidade { get; set; }
    }
}
