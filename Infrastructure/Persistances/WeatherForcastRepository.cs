using Ardalis.GuardClauses;
using AutoMapper;
using Domain.Agregate.Persistances;
using Domain.Models;

namespace Infrastructure.Persistances
{
    internal class WeatherForcastRepository : IPersistWeatherForcast
    {
        private readonly IMapper _mapper;

        public WeatherForcastRepository(IMapper mapper) 
        {
            _mapper = Guard.Against.Null(mapper, nameof(mapper));
        }

        public IReadOnlyCollection<WeatherForecast> GetAll()
        {
            IEnumerable<Entities.WeatherForecast> data = GenerateRandomData();
            return _mapper.Map<List<WeatherForecast>>(data)
                .AsReadOnly();
        }

        private IEnumerable<Entities.WeatherForecast> GenerateRandomData()
        {
            string[] summaries = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

            return Enumerable.Range(1, 5).Select(index => new Entities.WeatherForecast
            {
                Id = Guid.NewGuid(),
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = summaries[Random.Shared.Next(summaries.Length)]
            });
        }
    }
}
