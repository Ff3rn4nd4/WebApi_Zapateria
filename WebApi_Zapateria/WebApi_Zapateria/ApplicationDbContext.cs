using Microsoft.EntityFrameworkCore;
using WebApi_Zapateria.Entidades;

namespace WebApi_Zapateria
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        //creando las bases de datos 
        public DbSet<PedZap> PedZap {get;set;}
        public DbSet<Orden> Orden { get; set; }
    }
}
