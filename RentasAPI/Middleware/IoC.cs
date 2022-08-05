using DATA_ACCESS.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace RentasAPI.Middleware
{
    public static class IoC
    {
        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            //Inyectar los servicios del Repository Generico
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            return services;
        }
    }
}
