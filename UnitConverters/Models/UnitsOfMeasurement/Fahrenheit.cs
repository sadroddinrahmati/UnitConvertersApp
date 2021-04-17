using System;
using UnitConverters.Models.Base;
using UnitConverters.Service;

namespace UnitConverters.Models.UnitsOfMeasurement
{
    public class Fahrenheit : BaseUnitOfMeasurementModel
    {
        public static readonly Lazy<Fahrenheit> InstanceHolder = new Lazy<Fahrenheit>(() => new Fahrenheit());

        Fahrenheit() : base(UnitOfMeasurement.Temperature)
        {
        }

        public static Fahrenheit Instance => InstanceHolder.Value;

        public override double ConvertFromBaseUnits(double unitsInKelvin) => 
            Converter.CelsiusToFahrenheit(Converter.KelvinToCelsius(unitsInKelvin));

        public override double ConvertToBaseUnits(double unitsInFahrenheit) =>
            Converter.CelsiusToKelvin(Converter.FahrenheitToCelsius(unitsInFahrenheit));
    }
}
