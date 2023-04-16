using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Acervo.Models
{
    public class Usuarios
    {
        [Key]
        public int Id { get; set; }
        public String Usuario { get; set; }
        public String Senha { get; set; }
    }
}
