using RabbitMQ.Client;

namespace FluentRabbitMQ.Models
{
    public class DirectModelUnit : UnknownModelUnit
    {
        public DirectModelUnit(IModel model) : base(model)
        {
            this.Type = ExchangeType.Direct;
        }
    }
}
