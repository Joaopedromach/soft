using Microsoft.EntityFrameworkCore;

namespace Soft.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
        }

        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Clientes> Clientes { get; set; }

    }
}
