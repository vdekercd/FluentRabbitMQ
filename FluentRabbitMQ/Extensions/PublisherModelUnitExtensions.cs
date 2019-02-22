using FluentRabbitMQ.Models;
using RabbitMQ.Client;
using System.Text;

namespace FluentRabbitMQ.Extensions
{
    public static class PublisherModelUnitExtensions
    {
        public static PublisherModelUnit Send(this PublisherModelUnit @this, string message)
        {
            @this.ModelUnit.Message = message;
            return @this;
        }

        public static PublisherModelUnit To(this PublisherModelUnit @this, string routingKey = "")
        {
            var convertedBody = Encoding.UTF8.GetBytes(@this.ModelUnit.Message);

            @this.ModelUnit.Model.BasicPublish(exchange: @this.ModelUnit.ExchangeName,
                routingKey: routingKey,
                basicProperties: @this.ModelUnit.Properties,
                body: convertedBody);

            return @this;
        }
    }
}
