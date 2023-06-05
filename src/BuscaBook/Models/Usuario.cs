using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuscaBook.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public Guid UsuarioId { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a senha")]
        [DataType(DataType.Password)]
        public string? Senha { get; set; }
        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {  Admin,
       Usuario,
    }

}