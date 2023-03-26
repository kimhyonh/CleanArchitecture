using Ardalis.GuardClauses;
using AutoMapper;
using Domain.Persistances;
using Persistance.Entities;

namespace Persistance.Repositories
{
    internal class WeatherForcastRepository : IPersistWeatherForcast
    {
        private readonly IMapper _mapper;

        public WeatherForcastRepository(IMapper mapper)
        {
            _mapper = Guard.Against.Null(mapper, nameof(mapper));
        }

        public IReadOnlyCollection<Domain.Aggregates.WeatherForecast> GetAll()
        {
            IEnumerable<WeatherForecast> data = GenerateRandomData();
            return _mapper.Map<List<Domain.Aggregates.WeatherForecast>>(data)
                .AsReadOnly();
        }

        private IEnumerable<WeatherForecast> GenerateRandomData()
        {
            string[] summaries = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Id = Guid.NewGuid(),
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = summaries[Random.Shared.Next(summaries.Length)]
            });
        }
    }
}
