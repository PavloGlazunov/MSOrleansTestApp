using Microsoft.Extensions.DependencyInjection;
using Order.Ports;

namespace Order.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastrusture(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IOrderRepository, OrderRepository>();
        return serviceCollection;
    }
}