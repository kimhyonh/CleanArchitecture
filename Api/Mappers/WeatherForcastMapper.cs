namespace Api.Mappers;

internal class WeatherForcastMapper : AutoMapper.Profile
{
    public WeatherForcastMapper()
    {
        CreateMap<Domain.Models.WeatherForecast, Dtos.WeatherForecast>()
            .ForMember(m => m.TemperatureF, option => option.MapFrom(m => m.Temporature.Fahrenheit))
            .ForMember(m => m.TemperatureC, option => option.MapFrom(m => m.Temporature.Celsius));
    }
}
