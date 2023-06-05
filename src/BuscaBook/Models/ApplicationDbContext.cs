using Microsoft.EntityFrameworkCore;

namespace BuscaBook.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
       
    }
}
