using System;
using UnitConverters.Models.Base;
using UnitConverters.Service;

namespace UnitConverters.Models.UnitsOfMeasurement
{
    public class Celsius : BaseUnitOfMeasurementModel
    {
        private static readonly Lazy<Celsius> InstanceHolder = new(() => new Celsius());

        private Celsius() : base(UnitOfMeasurement.Temperature) { }

        public static Celsius Instance => InstanceHolder.Value;

        public override double ConvertFromBaseUnits(double unitsInKelvin) => Converter.KelvinToCelsius(unitsInKelvin);

        public override double ConvertToBaseUnits(double unitsInCelsius) => Converter.CelsiusToKelvin(unitsInCelsius);
    }
}
