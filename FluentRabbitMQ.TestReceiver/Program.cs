using FluentRabbitMQ.Extensions;
using RabbitMQ.Client;
using System;
using System.Linq;

namespace FluentRabbitMQ.TestReceiver
{
    class Program
    {
        static void Main(string[] args)
        {
            var listener = new ConnectionFactory().ConnectTo("localhost").AndUseExchange("AExchangeName").OfType(ExchangeType.Direct).GetReceiver();
            listener.WhenMessageFrom("ARoutingKey").Do((model, ea) => Console.WriteLine(" [x] Received {0}", ea.BodyAsString()));
            listener.WhenMessageFrom("AnotherRoutingKey").Do((model, ea) => Console.WriteLine(" [y] Received {0}", ea.BodyAsString()));
        }
    }
}
