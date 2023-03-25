namespace Infrastructure.Persistances.Entities;

public class WeatherForecast
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public int TemperatureC { get; set; }
    public string? Summary { get; set; }
}