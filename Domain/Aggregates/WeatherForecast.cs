using Domain.Common;
using Domain.Common.Interfaces;
using Domain.ValueObjects;

namespace Domain.Aggregates;

public class WeatherForecast : DomainEntity<Guid>, IAggregateRoot
{
    public WeatherForecast(Guid id)
        : base(id)
    {
    }

    public DateTime Date { get; set; }

    public Temporature Temporature { get; set; } = Temporature.WaterFreezed;

    public string? Summary { get; set; }
}