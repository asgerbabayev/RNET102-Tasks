
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

ConnectionFactory factory = new ConnectionFactory();
factory.Uri = new Uri("amqps://pwvsuavw:RPUXxE2Q21FVv9X4-C0DhAzrJW9RBOtT@shark.rmq.cloudamqp.com/pwvsuavw");

using (IConnection connection = factory.CreateConnection())
{
    using (IModel channel = connection.CreateModel())
    {
        channel.QueueDeclare(queue: "queue",
                             durable: false,
                             exclusive: false,
                             autoDelete: true);

        EventingBasicConsumer eventingBasicConsumer = new EventingBasicConsumer(channel);
        channel.BasicConsume(queue: "queue", autoAck: true, eventingBasicConsumer);
        eventingBasicConsumer.Received += (sender, e) =>
        {
            Console.WriteLine(Encoding.UTF8.GetString(e.Body.Span));
        };

    }
}
Console.Read();