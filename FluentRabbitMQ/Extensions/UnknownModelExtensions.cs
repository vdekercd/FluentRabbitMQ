using FluentRabbitMQ.Models;
using RabbitMQ.Client;
using System;

namespace FluentRabbitMQ.Extensions
{
    public static class UnknownModelExtensions
    {


        public static ModelUnit OfType(this UnknownModelUnit @this, string exchangeType)
        {
            switch (exchangeType)
            {
                case ExchangeType.Direct: return new ModelUnit(@this.Model) { ExchangeName = @this.ExchangeName, Type = ExchangeType.Direct };
                case ExchangeType.Fanout: return new FanoutModelUnit(@this.Model) { ExchangeName = @this.ExchangeName };
                // TODO case ExchangeType.Topic: return new DirectModelUnit(@this.Model) { ExchangeName = @this.ExchangeName};
                // TODO case ExchangeType.Headers: return new DirectModelUnit(@this.Model) { ExchangeName = @this.ExchangeName};
                default: throw new Exception("Unknown exchange type! Exchange type must be direct, fanout, topic or header.");
            }
        }
    }
}
