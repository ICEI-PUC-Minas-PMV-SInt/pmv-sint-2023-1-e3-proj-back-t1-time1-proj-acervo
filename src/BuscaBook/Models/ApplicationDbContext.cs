using Microsoft.EntityFrameworkCore;

namespace BuscaBook.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Livro> Livros { get; set; }
    }
}
