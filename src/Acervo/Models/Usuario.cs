using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System;

namespace Acervo.Models
{
    public class Usuario
    {
        [Key, MaxLength(30)]
        public Guid UsuarioId { get; set; }
        [Required, MaxLength(30)]
        public Guid ReservaId { get; set; }
        [Required, MaxLength(30)]
        public string Nome { get; set; }
        [Required, MaxLength(11)]
        public string Cpf { get; set; }
        [Required, MaxLength(15)]
        public string Senha { get; set; }
        [Required, MaxLength(30)]
        public string Email { get; set; }
        [Required, MaxLength(20)]
        public string Telefone { get; set; }
        public bool? FezReserva { get; set; }
    }
}
