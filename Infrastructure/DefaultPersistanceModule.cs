using Domain.Persistances;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Repositories;

namespace Infrastructure;

public static class DefaultPersistanceModule
{
    public static void AddInfrastructureLayer(this IServiceCollection services)
    {
        services.AddScoped<IPersistWeatherForcast, WeatherForcastRepository>();
    }
}
