using Microsoft.Extensions.DependencyInjection;
using Eshop.Product.Ports;

namespace Eshop.Product.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastrusture(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IProductRepository, ProductRepository>();
        return serviceCollection;
    }
}