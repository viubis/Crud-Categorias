using prmToolkit.NotificationPattern;

namespace Categorias.Domain.Entidades.Contratos
{
    public static class CategoriasContratos
    {
        public static void AdicionarCategoriaContrato(this Categoria categorias) 
        {
            new AddNotifications<Categoria>(categorias)
                .IfNull(c => c.Codigo)
                .IfNullOrInvalidLength(c => c.Titulo, 1, 100)
                .IfNullOrInvalidLength(p => p.Descricao, 1, 200);
        }

        public static void AtualizarCategoriaContrato(this Categoria categorias)
        {
            new AddNotifications<Categoria>(categorias)
                .IfNull(c => c.Codigo)
                .IfNullOrInvalidLength(c => c.Titulo, 1, 100)
                .IfNullOrInvalidLength(p => p.Descricao, 1, 200);
        }
    }
}
