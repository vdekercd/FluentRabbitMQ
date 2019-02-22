using FluentRabbitMQ.Models;
using RabbitMQ.Client;
using System.Text;

namespace FluentRabbitMQ.Extensions
{
    public static class PublisherModelUnitExtensions
    {
        public static ReceiverModelUnit Send(this ReceiverModelUnit @this, string message)
        {
            @this.ModelUnit.Message = message;
            return @this;
        }

        public static ReceiverModelUnit To(this ReceiverModelUnit @this, string routingKey = "")
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
