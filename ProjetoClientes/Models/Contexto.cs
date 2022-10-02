using Microsoft.EntityFrameworkCore;

namespace ProjetoClientes.Models
{
    public class Contexto : DbContext

    {
        public Contexto(DbContextOptions<Contexto> options):base(options)
        {

        }
        public DbSet<Clientes> Clientes { get; set; }

    }
}
