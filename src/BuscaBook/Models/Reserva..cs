using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuscaBook.Models
{
    [Table("Reserva")]
    public class Reserva
    {
        [Key]
        public Guid ReservaId { get; set; }

        [Required(ErrorMessage = "Usuário Obrigatório")]
        public string Usuário { get; set; }

        [Required(ErrorMessage = "Livro obrigatório")]
        public Livro Livro { get; set; }

        [Required(ErrorMessage = "Data de Aluguel Obrigatória")]
        public DateTime DataDeAluguel { get; set; }

        [Display(Name = "Data de Expiração")]
        public DateTime DataDeExpiracao { get; set; }
    }
}
