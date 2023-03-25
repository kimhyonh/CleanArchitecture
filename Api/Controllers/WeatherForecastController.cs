using Api.Dtos;
using Ardalis.GuardClauses;
using AutoMapper;
using Domain.Agregate.Persistances;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMapper _mapper;
        private readonly IPersistWeatherForcast _repo;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            IMapper mapper,
            IPersistWeatherForcast repo
        )
        {
            _logger = Guard.Against.Null(logger, nameof(logger));
            _mapper = Guard.Against.Null(mapper, nameof(mapper));
            _repo = Guard.Against.Null(repo, nameof(repo));
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            _logger.LogInformation("Loading WeatherForcast...");

            return _mapper.Map<IEnumerable<WeatherForecast>>(_repo.GetAll());
        }
    }
}