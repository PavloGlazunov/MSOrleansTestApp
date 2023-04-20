using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Eshop.Order.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection serviceCollection)
    {
        var assemblyType = Assembly.GetAssembly(typeof(DependencyInjection));
        
        serviceCollection.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assemblyType));
        serviceCollection.AddAutoMapper(assemblyType);

        return serviceCollection;
    }
}