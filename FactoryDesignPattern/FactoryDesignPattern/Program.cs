using FactoryDesignPattern;
using FactoryDesignPattern.Classes;
using System;

class Program
{
    public static void Main(string[] args)
    {
        INotification notification = ClientFactory.GetNotification("Email");
        notification.send("Hello, this is a factory design pattern Leave Eails!");
        INotification SMs =  ClientFactory.GetNotification("SMS");
        SMs.send("Hello, this is a factory design pattern SMS!");
        INotification push =  ClientFactory.GetNotification("PUSH");
        push.send("Hello, this is a factory design pattern PUSH!");

    }


}