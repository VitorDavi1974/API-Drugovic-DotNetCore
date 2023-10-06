using Drugovich.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.RegularExpressions;

namespace Drugovich.DataContext.Map
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.cnpj).IsRequired().HasMaxLength(14);
            builder.Property(x => x.nome).IsRequired().HasMaxLength(40);
            builder.Property(x => x.fundacao).IsRequired();

            builder.HasOne(x => x.Grupo);
        }
    }
}
