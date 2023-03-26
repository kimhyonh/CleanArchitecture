using Domain.ValueObjects;

namespace Persistance.Mappers;

internal class WeatherForcastMapper : AutoMapper.Profile
{
    public WeatherForcastMapper()
    {
        CreateMap<Domain.Aggregates.WeatherForecast, Entities.WeatherForecast>()
            .ForMember(m => m.TemperatureC, options => options.MapFrom(src => src.Temporature.Celsius));

        CreateMap<Entities.WeatherForecast, Domain.Aggregates.WeatherForecast>()
            .ForMember(m => m.Temporature, option => option.MapFrom(src => Temporature.CreateWithCelsius(src.TemperatureC)));
    }
}
