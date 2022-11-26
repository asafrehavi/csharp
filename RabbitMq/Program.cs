//// See https://aka.ms/new-console-template for more information



//using RabbitMq;
//using RabbitMQ.Client.Events;
//using RabbitMQ.Client;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//new Sender();
//var factory = new ConnectionFactory() { HostName = "localhost" };
//using (var connection = factory.CreateConnection())
//using (var channel = connection.CreateModel())
//{
//    channel.QueueDeclare(queue: "FromNodeToC#",
//                         durable: false,
//                         exclusive: false,
//                         autoDelete: false,
//                         arguments: null);

//    var consumer = new EventingBasicConsumer(channel);
//    consumer.Received += (model, ea) =>
//    {
//        var body = ea.Body.ToArray();
//        var message = Encoding.UTF8.GetString(body);
//        Console.WriteLine(" [x] Received {0}", message);
//    };
//    channel.BasicConsume(queue: "FromNodeToC#",
//                         autoAck: true,
//                         consumer: consumer);
//}

//Console.WriteLine(" Press [enter] to exit.");
//Console.ReadLine();




using RabbitMq;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

class RabbitMqManager
{
    public static void Main()
    {
        var sender = new Sender();
        var receiver = new Receiver();
    }
}
