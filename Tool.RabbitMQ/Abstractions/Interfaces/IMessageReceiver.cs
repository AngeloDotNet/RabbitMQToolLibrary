namespace Tool.RabbitMQ.Abstractions.Interfaces;

public interface IMessageReceiver<T> where T : class
{
    Task ReceiveAsync(T message, CancellationToken cancellationToken);
}