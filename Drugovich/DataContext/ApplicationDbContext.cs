using Drugovich.DataContext.Map;
using Drugovich.Entities;
using Microsoft.EntityFrameworkCore;

namespace Drugovich.DataContext
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Gerente> Gerentes { get; set; }
        public DbSet<Grupo> Grupos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new GerenteMap());
            modelBuilder.ApplyConfiguration(new GrupoMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}
