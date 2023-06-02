using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuscaBook.Models
{
    [Table("Livros")]
    public class Livro
    {
        [Key]
        public Guid LivroId { get; set; }
        [Required(ErrorMessage = "Titulo obrigatorio!")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Tipo obrigatorio!")]
        public string Tipo { get; set; }
        [Required(ErrorMessage = "Autor obrigatorio!")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "Localizacao obrigatorio!")]
        public string Localizacao { get; set; }
        [Required(ErrorMessage = "AnoPublicacao obrigatorio!")]
        public DateTimeOffset AnoPublicacao { get; set; }
        [Required(ErrorMessage = "Obrigatorio!")]
        public bool? Reservado { get; set; }
        [Required]
        public int? NumeroPaginas { get; set; }
    }
}
