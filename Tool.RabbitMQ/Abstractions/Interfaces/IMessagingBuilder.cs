using Microsoft.Extensions.DependencyInjection;

namespace Tool.RabbitMQ.Abstractions.Interfaces;

public interface IMessagingBuilder
{
    IServiceCollection Services { get; }
}