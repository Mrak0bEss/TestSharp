using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using System.Reflection;
namespace Domain
{
    public static class DomainSetup
    {
        public static void AddDomain(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
