using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsC_.DependencyInjection
{
    public interface INotificationService
    {
        void SendNotification(string message);
    }
}
