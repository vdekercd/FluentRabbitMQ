using FluentRabbitMQ.Models;
using RabbitMQ.Client;

namespace FluentRabbitMQ.Extensions
{
    public static class IModelExtensions
    {
        public static UnknownModelUnit AndUseExchange(this IModel @this, string exchangeName = "")
        {
            return new UnknownModelUnit(@this) { ExchangeName = exchangeName};
        }

        public static ModelUnit AsAutoDelete(this ModelUnit @this)
        {
            @this.IsAutoDelete = true;
            return @this;
        }

        public static ModelUnit AsDurable(this ModelUnit @this)
        {
            @this.IsDurable = true;
            return @this;
        }

        public static ReceiverModelUnit GetReceiver(this ModelUnit @this)
        {
            @this.Model.ExchangeDeclare(@this.ExchangeName, @this.Type);
            return new ReceiverModelUnit(@this);
        }

        public static PublisherModelUnit GetPublisher(this ModelUnit @this)
        {
            @this.Model.ExchangeDeclare(@this.ExchangeName, @this.Type);
            return new PublisherModelUnit(@this);
        }

        public static ModelUnit SetProperties(ModelUnit @this, IBasicProperties properties)
        {
            @this.Properties = properties;
            return @this;
        }
    }
}
