using FluentRabbitMQ.Models;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;

namespace FluentRabbitMQ.Extensions
{
    public static class ReceiverModelUnitExtensions
    {
        public static ReceiverModelUnit WhenMessageFrom(this ReceiverModelUnit @this, string routingKey)
        {
            @this.ModelUnit.QueueName = @this.ModelUnit.Model.QueueDeclare().QueueName;

            @this.ModelUnit.Model.QueueBind(@this.ModelUnit.QueueName,
                @this.ModelUnit.ExchangeName,
                routingKey);

            return @this;
        }

        public static ReceiverModelUnit Do(this ReceiverModelUnit @this, EventHandler<BasicDeliverEventArgs> action)
        {
            var consumer = new EventingBasicConsumer(@this.ModelUnit.Model);
            consumer.Received += action;

            @this.ModelUnit.Model.BasicConsume(queue: @this.ModelUnit.QueueName,
                autoAck: true,
                consumer: consumer);

            return @this;
        }
    }
}
