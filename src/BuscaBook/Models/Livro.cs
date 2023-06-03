using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuscaBook.Models
{
    [Table("Livros")]
    public class Livro
    {
        [Key]
        public Guid LivroId { get; set; }

        [Required(ErrorMessage = "Título obrigatório!")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Tipo obrigatório!")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Autor obrigatório!")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "Localização obrigatória!")]
        public string Localizacao { get; set; }

        [Required(ErrorMessage = "Ano de publicação obrigatório!")]
        public DateTimeOffset AnoPublicacao { get; set; }

        public bool Reservado { get; set; } = false;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Tempo de reserva")]
        public DateTime? TempoReserva { get; set; }

        public bool Alugado { get; set; } = false;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Tempo de aluguel")]
        public DateTime? TempoAluguel { get; set; }
    }
}