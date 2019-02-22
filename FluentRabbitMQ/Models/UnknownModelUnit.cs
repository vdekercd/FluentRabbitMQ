using RabbitMQ.Client;

namespace FluentRabbitMQ.Models
{
    public class UnknownModelUnit : ModelUnit
    {
        public UnknownModelUnit(IModel model) : base(model) { }
    }
}
