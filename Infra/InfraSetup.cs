using Domain.Abstraction;
using Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infra
{
    public static class InfraSetup
    {
        public static void AddInfra(this IServiceCollection service)
        {
            service.AddTransient<IUserRepository, UserRepository>();
        }
    }
}
