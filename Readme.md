<p align="center"><img src="https://www.rabbitmq.com/img/RabbitMQ-logo.svg" alt="enter image description here"></p>

# Fluent RabbitMQ

The simplest way to use RabbitMQ

## Publish message


```cs
var publisher = new ConnectionFactory().ConnectTo("localhost").AndUseExchange("AExchangeName").OfType(ExchangeType.Direct).GetPublisher();
publisher.Send("A message").To("ARoutingKey");
publisher.Send("Another message").To("AnotherRoutingKey");
```
<h2 id="read-message">Read message</h2>

