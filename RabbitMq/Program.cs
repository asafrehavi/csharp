




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
