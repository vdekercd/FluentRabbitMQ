namespace FluentRabbitMQ.Models
{
    public class ReceiverModelUnit
    {
        public ReceiverModelUnit(ModelUnit modelUnit)
        {
            ModelUnit = modelUnit;
        }

        public ModelUnit ModelUnit { get; set; }
    }
}
