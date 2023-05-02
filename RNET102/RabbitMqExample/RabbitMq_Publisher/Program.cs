
using RabbitMQ.Client;
using System.Text;

ConnectionFactory factory = new ConnectionFactory();
factory.Uri = new Uri("amqps://pwvsuavw:RPUXxE2Q21FVv9X4-C0DhAzrJW9RBOtT@shark.rmq.cloudamqp.com/pwvsuavw");

using (IConnection connection = factory.CreateConnection())
{
    using (var channel = connection.CreateModel())
    {
        channel.QueueDeclare(queue: "queue",
                             durable: false,
                             exclusive: false,
                             autoDelete: true);
        var byteData = Encoding.UTF8.GetBytes("RNET102 Urekdir");

        for (int i = 0; i < 1000000; i++)
        {
            channel.BasicPublish(exchange: "",
                             routingKey: "queue",
                             body: byteData);
            Console.WriteLine("Mesaj getdi");
        }
    }
}