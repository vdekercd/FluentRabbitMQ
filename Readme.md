---


---

<p><img src="https://www.rabbitmq.com/img/RabbitMQ-logo.svg" alt="enter image description here"></p>
<h1 id="fluent-rabbitmq">Fluent RabbitMQ</h1>
<p>The simplest way to use RabbitMQ</p>
<h2 id="publish-message">Publish message</h2>
<pre><code>    var publisher = new ConnectionFactory().ConnectTo("localhost").AndUseExchange("AExchangeName").OfType(ExchangeType.Direct).GetPublisher();
    publisher.Send("A message").To("ARoutingKey");
    publisher.Send("Another message").To("AnotherRoutingKey");
</code></pre>
<h2 id="read-message">Read message</h2>

