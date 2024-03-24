using Categorias.Domain.Entidades;


namespace Categorias.Domain.Interfaces.Repositorios
{
    public interface IRepositorioBase<TEntity> where TEntity : EntidadeBase
    {
        IEnumerable<TEntity> List();
        TEntity Get(Guid id);
        IQueryable<TEntity> Query();
        void Add (TEntity entity);
        void Update (TEntity entity);
        void Delete (TEntity entity);
        void Commit();
    }
}
