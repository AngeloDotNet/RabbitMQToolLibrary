using Microsoft.Extensions.DependencyInjection;
using Tool.RabbitMQ.Abstractions.Interfaces;

namespace Tool.RabbitMQ.Abstractions;

internal class DefaultMessagingBuilder : IMessagingBuilder
{
    public IServiceCollection Services { get; }

    public DefaultMessagingBuilder(IServiceCollection services)
    {
        Services = services;
    }
}