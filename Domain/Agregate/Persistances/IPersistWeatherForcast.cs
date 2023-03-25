using Domain.Common.Interfaces;
using Domain.Models;

namespace Domain.Agregate.Persistances;

public interface IPersistWeatherForcast : IRepository<WeatherForecast>
{
    /**
     * Using this interface to provide 'WeatherForecast' specific 
     * persistance methods.
     */
}
