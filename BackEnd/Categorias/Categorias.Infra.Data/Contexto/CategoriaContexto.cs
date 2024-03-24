using Categorias.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using prmToolkit.NotificationPattern;

namespace Categorias.Infra.Data.Contexto
{
    public class CategoriaContexto : DbContext
    {
        public CategoriaContexto(DbContextOptions<CategoriaContexto> options) : base(options) { }

        public DbSet<Categoria> CategoriaDbSet { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Notification>();

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoriaContexto).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
