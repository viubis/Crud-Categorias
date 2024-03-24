using Categorias.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Categorias.Infra.Data.Repositorios
{
    public class CategoriaConfiguracao : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Codigo)
                .IsRequired();

            builder.Property(p => p.Titulo)
                .IsRequired();

            builder.Property(p => p.Descricao)
                .IsRequired();

            builder.ToTable("Categoria");
        }
    }
}
