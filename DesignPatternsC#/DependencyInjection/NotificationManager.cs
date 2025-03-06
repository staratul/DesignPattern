using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsC_.DependencyInjection
{
    public class NotificationManager
    {
        private readonly INotificationService _notificationService;

        // Constructor Injection
        public NotificationManager(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }   

        public void Notify(string message)
        {
            _notificationService.SendNotification(message);
        }
    }
}
