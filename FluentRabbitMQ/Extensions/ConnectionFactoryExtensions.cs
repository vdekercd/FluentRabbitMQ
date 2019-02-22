using RabbitMQ.Client;

namespace FluentRabbitMQ.Extensions
{
    public static class ConnectionFactoryExtensions
    {
        public static IModel ConnectTo(this ConnectionFactory @this, string hostName)
        {
            return @this.CreateConnection().CreateModel();
        } 

        public static IModel ConnectTo(this ConnectionFactory @this, string hostName, string username, string password)
        {
            @this.HostName = hostName;
            @this.UserName = username;
            @this.Password = password; 
            return @this.CreateConnection().CreateModel();
        }
    }
}
