namespace Tool.RabbitMQ.Abstractions.Interfaces;

public interface IMessageSender
{
    Task PublishAsync<T>(T message, int priority = 1) where T : class;
}