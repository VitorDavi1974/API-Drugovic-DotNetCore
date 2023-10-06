using Drugovich.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.RegularExpressions;

namespace Drugovich.DataContext.Map
{
    public class GrupoMap : IEntityTypeConfiguration<Grupo>
    {
        public void Configure(EntityTypeBuilder<Grupo> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.nome).IsRequired().HasMaxLength(150);
        }
    }
}
