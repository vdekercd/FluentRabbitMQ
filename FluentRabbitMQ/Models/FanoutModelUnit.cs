using RabbitMQ.Client;

namespace FluentRabbitMQ.Models
{
    public class FanoutModelUnit : ModelUnit
    {
        public FanoutModelUnit(IModel model) : base(model) {}
    }
}
