using Acervo.Models;
using Microsoft.EntityFrameworkCore;


namespace Acervo.Dados

{
    public class LoginDbContext : DbContext
    {
        public LoginDbContext(DbContextOptions<LoginDbContext>options) : base(options)
        {

        }
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}
