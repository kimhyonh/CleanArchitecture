using Domain.Agregate.Persistances;
using Infrastructure.Persistances;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DefaultInfrastructureModule
{
    public static void AddInfrastructureLayer(this IServiceCollection services)
    {
        services.AddScoped<IPersistWeatherForcast, WeatherForcastRepository>();
    }
}
