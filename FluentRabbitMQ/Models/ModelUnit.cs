using RabbitMQ.Client;

namespace FluentRabbitMQ.Models
{
    public class ModelUnit
    {
        public ModelUnit(IModel model)
        {
            this.Model = model;
        }

        public IModel Model { get; }
        public string ExchangeName { get; set; }
        public string Type { get; set; }
        public string QueueName { get; set; }
        public IBasicProperties Properties { get; set; }
        public string Message { get; set; }
        public bool IsDurable { get; set; }
        public bool IsAutoDelete { get; set; }
    }
}
