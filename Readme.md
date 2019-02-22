---


---

<p><img src="https://www.rabbitmq.com/img/RabbitMQ-logo.svg" alt="enter image description here"></p>
<h1 id="fluent-rabbitmq">Fluent RabbitMQ</h1>
<p>The simplest way to use RabbitMQ</p>
<h2 id="publish-message">Publish message</h2>
<pre class=" language-csharp"><code class="prism  language-csharp">        <span class="token keyword">var</span> publisher <span class="token operator">=</span> <span class="token keyword">new</span> <span class="token class-name">ConnectionFactory</span><span class="token punctuation">(</span><span class="token punctuation">)</span><span class="token punctuation">.</span><span class="token function">ConnectTo</span><span class="token punctuation">(</span><span class="token string">"localhost"</span><span class="token punctuation">)</span><span class="token punctuation">.</span><span class="token function">AndUseExchange</span><span class="token punctuation">(</span><span class="token string">"AExchangeName"</span><span class="token punctuation">)</span><span class="token punctuation">.</span><span class="token function">OfType</span><span class="token punctuation">(</span>ExchangeType<span class="token punctuation">.</span>Direct<span class="token punctuation">)</span><span class="token punctuation">.</span><span class="token function">GetPublisher</span><span class="token punctuation">(</span><span class="token punctuation">)</span><span class="token punctuation">;</span>
        publisher<span class="token punctuation">.</span><span class="token function">Send</span><span class="token punctuation">(</span><span class="token string">"A message"</span><span class="token punctuation">)</span><span class="token punctuation">.</span><span class="token function">To</span><span class="token punctuation">(</span><span class="token string">"ARoutingKey"</span><span class="token punctuation">)</span><span class="token punctuation">;</span>
        publisher<span class="token punctuation">.</span><span class="token function">Send</span><span class="token punctuation">(</span><span class="token string">"Another message"</span><span class="token punctuation">)</span><span class="token punctuation">.</span><span class="token function">To</span><span class="token punctuation">(</span><span class="token string">"AnotherRoutingKey"</span><span class="token punctuation">)</span><span class="token punctuation">;</span>
        ```

<span class="token preprocessor property">## Read message</span>



</code></pre>

