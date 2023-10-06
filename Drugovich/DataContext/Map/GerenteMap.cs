using Drugovich.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.RegularExpressions;

namespace Drugovich.DataContext.Map
{
    public class GerenteMap : IEntityTypeConfiguration<Gerente>
    {
        public void Configure(EntityTypeBuilder<Gerente> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.nome).IsRequired().HasMaxLength(150);
            builder.Property(x => x.email).IsRequired().HasMaxLength(150);
            builder.Property(x => x.nivel).IsRequired();

        }
    }
}
