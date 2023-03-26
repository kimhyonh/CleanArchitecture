using Domain.Aggregates;
using Domain.Common.Interfaces;

namespace Domain.Persistances;

public interface IPersistWeatherForcast : IRepository<WeatherForecast>
{
    /**
     * Using this interface to provide 'WeatherForecast' specific 
     * persistance methods.
     */
}
