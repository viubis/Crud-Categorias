using prmToolkit.NotificationPattern;

namespace Categorias.Domain.Entidades
{
    public abstract class EntidadeBase : Notifiable
    {
        public Guid Id { get; private set; }

    }
}
