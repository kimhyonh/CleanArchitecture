using Domain.Agregate.Models;

namespace Infrastructure.Persistances.Mappers;

internal class WeatherForcastMapper : AutoMapper.Profile
{
    public WeatherForcastMapper()
    {
        CreateMap<Domain.Models.WeatherForecast, Entities.WeatherForecast>()
            .ForMember(m => m.TemperatureC, options => options.MapFrom(src => src.Temporature.Celsius));

        CreateMap<Entities.WeatherForecast, Domain.Models.WeatherForecast>()
            .ForMember(m => m.Temporature, option => option.MapFrom(src => Temporature.CreateWithCelsius(src.TemperatureC)));
    }
}
