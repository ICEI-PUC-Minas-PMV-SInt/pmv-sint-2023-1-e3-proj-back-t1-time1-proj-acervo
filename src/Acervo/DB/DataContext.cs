using Acervo.Models;
using Microsoft.EntityFrameworkCore;

namespace Acervo.DB
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Livro> Livros { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            base.OnModelCreating(modelBuilder);
        }
    }
}