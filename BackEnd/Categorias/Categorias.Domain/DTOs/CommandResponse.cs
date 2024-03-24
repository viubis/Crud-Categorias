using prmToolkit.NotificationPattern;

namespace Categorias.Domain.DTOs
{
    public class CommandResponse
    {
        public bool Success { get; }
        public object Data { get; }
        public IEnumerable<Notification> Notifications { get; }

        public CommandResponse(object data, INotifiable notifications)
        {
            Success = notifications.IsValid();
            Data = notifications.IsValid() ? data : null;
            Notifications = notifications.Notifications;
        }

        public CommandResponse(INotifiable notifications)
        {
            Success = false;
            Data = null;
            Notifications = notifications.Notifications;
        }

    }
}
