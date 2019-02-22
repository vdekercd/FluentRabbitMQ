using RabbitMQ.Client.Events;
using System.Text;

namespace FluentRabbitMQ.Extensions
{
    public static class BasicDeliverEventArgsExtensions
    {
        public static string BodyAsString(this BasicDeliverEventArgs @this) => Encoding.UTF8.GetString(@this.Body);
    }
}
