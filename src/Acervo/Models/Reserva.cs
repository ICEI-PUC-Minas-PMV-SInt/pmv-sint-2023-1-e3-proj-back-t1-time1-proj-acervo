using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System;

namespace Acervo.Models
{
    public class Reserva
    {
        [Key, MaxLength(30)]
        public Guid ReservaId { get; set; }
        [Required]
        public Guid UsuarioId { get; set; }
        [Required]
        public Guid LivroId { get; set; }
        [Required]
        public DateTimeOffset DataReserva { get; set; }
    }
}