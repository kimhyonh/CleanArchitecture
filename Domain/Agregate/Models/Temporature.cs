using Domain.Common;

namespace Domain.Agregate.Models
{
    public class Temporature : ValueObject
    {
        private const double CelsiusToFahrenheit = 0.5556;

        public static Temporature WaterFreezed = CreateWithCelsius(0);

        public int Celsius { get; private set; }
        public int Fahrenheit => 32 + (int)(Celsius / CelsiusToFahrenheit);

        private Temporature(int celsius)
        {
            this.Celsius = celsius;
        }

        public static Temporature CreateWithCelsius(int celsius)
        {
            return new Temporature(celsius);
        }

        public static Temporature CreateWithFahrenheit(int fahrenheit)
        {
            return new Temporature((int)((fahrenheit - 32) * CelsiusToFahrenheit));
        }

        public override bool PropertiesAreEqual(ValueObject other)
        {
            return other is Temporature temperature
                && temperature.Celsius == Celsius;
        }

        public override int PropertiesHashCode()
        {
            return HashCode.Combine(Celsius);
        }
    }
}
