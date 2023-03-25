using Domain.Agregate.Models;
using Domain.Common;
using Domain.Common.Interfaces;

namespace Domain.Models
{
    public class WeatherForecast : Entity<Guid>, IAggregateRoot
    {
        public WeatherForecast(Guid id) 
            : base(id)
        {
        }

        public DateTime Date { get; set; }

        public Temporature Temporature { get; set; } = Temporature.WaterFreezed;

        public string? Summary { get; set; }
    }
}