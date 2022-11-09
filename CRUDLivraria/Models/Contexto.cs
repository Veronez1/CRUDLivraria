using Microsoft.EntityFrameworkCore;

namespace CRUDLivraria.Models
{
    public class Contexto : DbContext
    {
        public Contexto( DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Livro> Livro { get; set; }

    }
}
