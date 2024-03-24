using Microsoft.EntityFrameworkCore;
using Categorias.Domain.Entidades;
using Categorias.Domain.Interfaces.Repositorios;
using Categorias.Infra.Data.Contexto;

namespace Categorias.Infra.Data.Repositorios
{
    public class RepositorioBase<TEntity> : IRepositorioBase<TEntity> where TEntity : EntidadeBase
    {
        protected readonly DbSet<TEntity> DbSet;
        protected readonly CategoriaContexto _context;

        public RepositorioBase(CategoriaContexto context)
        {
            DbSet = context.Set<TEntity>();
            _context = context;
        }

        public void Add(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public TEntity Get(Guid id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<TEntity> List()
        {
            return DbSet.AsEnumerable();
        }

        public void Update(TEntity entity)
        {
            DbSet.Update(entity);
        }

        public IQueryable<TEntity> Query()
        {
            return DbSet.AsQueryable();
        }
    }
}

