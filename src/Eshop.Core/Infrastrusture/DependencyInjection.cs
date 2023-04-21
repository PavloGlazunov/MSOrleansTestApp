using Microsoft.Extensions.DependencyInjection;

namespace Eshop.Core.Infrastrusture
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastrusture(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton(typeof(IRepository<>), typeof(GenericRepository<>));
            return serviceCollection;
        }
    }
}
