using Microsoft.EntityFrameworkCore;
using Categorias.Domain.Entidades;
using Categorias.Domain.Interfaces.Repositorios;
using Categorias.Infra.Data.Contexto;

namespace Categorias.Infra.Data.Repositorios
{
    public class RepositorioCategoria : RepositorioBase<Categoria>, IRepositorioCategoria
    {
        public RepositorioCategoria(CategoriaContexto context) : base(context)
        {
        }
    }
}
