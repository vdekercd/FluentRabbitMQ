using FluentRabbitMQ.Extensions;
using RabbitMQ.Client;
using System;
using System.Linq;

namespace FluentRabbitMQ.TestPublisher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Appuyez pour envoyer le message");
            Console.ReadLine();

            var publisher = new ConnectionFactory().ConnectTo("localhost").AndUseExchange("AExchangeName").OfType(ExchangeType.Direct).GetPublisher();
            publisher.Send("A message").To("ARoutingKey");
            publisher.Send("Another message").To("AnotherRoutingKey");
        }
    }
}
