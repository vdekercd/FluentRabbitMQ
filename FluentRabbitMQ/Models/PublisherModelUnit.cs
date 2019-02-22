namespace FluentRabbitMQ.Models
{
    public class PublisherModelUnit
    {
        public PublisherModelUnit(ModelUnit modelUnit)
        {
            ModelUnit = modelUnit;
        }

        public ModelUnit ModelUnit { get; set; }
    }
}
