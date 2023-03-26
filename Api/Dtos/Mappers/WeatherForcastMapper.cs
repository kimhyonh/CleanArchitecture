namespace Api.Dtos.Mappers;

internal class WeatherForcastMapper : AutoMapper.Profile
{
    public WeatherForcastMapper()
    {
        CreateMap<Domain.Aggregates.WeatherForecast, WeatherForecast>()
            .ForMember(m => m.TemperatureF, option => option.MapFrom(m => m.Temporature.Fahrenheit))
            .ForMember(m => m.TemperatureC, option => option.MapFrom(m => m.Temporature.Celsius));
    }
}
