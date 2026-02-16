using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Classes
{
    class PushNotification : INotification
    {
              public void send(string message)
        {
            Console.WriteLine($"Sending push notification: {message}");
        }
    }
}
