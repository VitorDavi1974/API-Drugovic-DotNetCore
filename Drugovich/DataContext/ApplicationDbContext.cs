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

            modelBuilder.Entity<Grupo>().HasData(
                new Grupo
                {
                    id = 1,
                    nome = "Grupo 1"
                }
            );

            modelBuilder.Entity<Gerente>().HasData(
                new Gerente
                {
                    id = 1,
                    nome = "Gerente 1",
                    email = "gerente1@gmail.com",
                    nivel = 1
                },
                new Gerente
                {
                    id = 2,
                    nome = "Gerente 2",
                    email = "gerente2@gmail.com",
                    nivel = 2
                },
                new Gerente
                {
                    id = 3,
                    nome = "Gerente 3",
                    email = "gerente3@gmail.com",
                    nivel = 1
                },
                new Gerente
                {
                    id = 4,
                    nome = "Gerente 4",
                    email = "gerente4@gmail.com",
                    nivel = 2
                },
                new Gerente
                {
                    id = 5,
                    nome = "Gerente 5",
                    email = "gerente5@gmail.com",
                    nivel = 1
                }
            );

            modelBuilder.Entity<Cliente>().HasData(
                new
                {
                    id = 1,
                    cnpj = "1234567890",
                    nome = "Cliente 1",
                    fundacao = new DateTime(2008, 12, 10, 12, 00, 00, DateTimeKind.Utc),
                    Grupoid = 1
                },
                new
                {
                    id = 2,
                    cnpj = "1234567891",
                    nome = "Cliente 2",
                    fundacao = new DateTime(2009, 12, 10, 12, 00, 00, DateTimeKind.Utc),
                    Grupoid = 1
                },
                new
                {
                    id = 3,
                    cnpj = "1234567892",
                    nome = "Cliente 3",
                    fundacao = new DateTime(2010, 12, 10, 12, 00, 00, DateTimeKind.Utc),
                    Grupoid = 1
                },
                new
                {
                    id = 4,
                    cnpj = "1234567893",
                    nome = "Cliente 4",
                    fundacao = new DateTime(2011, 12, 10, 12, 00, 00, DateTimeKind.Utc),
                    Grupoid = 1
                },
                new
                {
                    id = 5,
                    cnpj = "1234567894",
                    nome = "Cliente 5",
                    fundacao = new DateTime(2012, 12, 10, 12, 00, 00, DateTimeKind.Utc),
                    Grupoid = 1
                },
                new
                {
                    id = 6,
                    cnpj = "1234567895",
                    nome = "Cliente 6",
                    fundacao = new DateTime(2013, 12, 10, 12, 00, 00, DateTimeKind.Utc),
                    Grupoid = 1
                },
                new
                {
                    id = 7,
                    cnpj = "1234567896",
                    nome = "Cliente 7",
                    fundacao = new DateTime(2014, 12, 10, 12, 00, 00, DateTimeKind.Utc),
                    Grupoid = 1
                },
                new
                {
                    id = 8,
                    cnpj = "1234567897",
                    nome = "Cliente 8",
                    fundacao = new DateTime(2015, 12, 10, 12, 00, 00, DateTimeKind.Utc),
                    Grupoid = 1
                },
                new
                {
                    id = 9,
                    cnpj = "1234567898",
                    nome = "Cliente 9",
                    fundacao = new DateTime(2016, 12, 10, 12, 00, 00, DateTimeKind.Utc),
                    Grupoid = 1
                },
                new
                {
                    id = 10,
                    cnpj = "1234567899",
                    nome = "Cliente 10",
                    fundacao = new DateTime(2017, 12, 10, 12, 00, 00, DateTimeKind.Utc),
                    Grupoid = 1
                }
                );

            base.OnModelCreating(modelBuilder);
        }

    }
}
