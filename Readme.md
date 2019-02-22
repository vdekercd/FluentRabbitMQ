<p align="center"><img src="https://www.rabbitmq.com/img/RabbitMQ-logo.svg" alt="enter image description here"></p>

# Fluent RabbitMQ

The easiest way to use RabbitMQ

* [Publish message](#publish-message)
* [Receive message](#receive-message)

## Publish message

```cs
var publisher = new ConnectionFactory().ConnectTo("localhost").AndUseExchange("AExchangeName").OfType(ExchangeType.Direct).GetPublisher();
publisher.Send("A message").To("ARoutingKey");
publisher.Send("Another message").To("AnotherRoutingKey");
```

## Receive message

```cs
var receiver = new ConnectionFactory().ConnectTo("localhost").AndUseExchange("AExchangeName").OfType(ExchangeType.Direct).GetReceiver();
receiver.WhenMessageFrom("ARoutingKey").Do((model, ea) => Console.WriteLine(" [x] Received {0}", ea.BodyAsString()));
receiver.WhenMessageFrom("AnotherRoutingKey").Do((model, ea) => Console.WriteLine(" [y] Received {0}", ea.BodyAsString()));
```

## Contributing

Feel free to [open an issue].

[open an issue]: https://github.com/vdekercd/FluentRabbitMQ/issues/