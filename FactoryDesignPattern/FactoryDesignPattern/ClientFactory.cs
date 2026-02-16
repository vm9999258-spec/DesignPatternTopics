using FactoryDesignPattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public static class ClientFactory
    {
        public static INotification GetNotification(string type)
        {
            switch (type)
            {
                case "Email":
                    return new EmailNotification();
                case "SMS":
                    return new SMSNotification();
                case "Push":
                    return new PushNotification(); // Ensure PushNotification implements INotification

                default:
                    throw new ArgumentException("Invalid notification type");
            }
        }
        
    }
   
}
