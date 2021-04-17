using System;
using UnitConverters.Models.Base;
using UnitConverters.Service;

namespace UnitConverters.Models.UnitsOfMeasurement
{
    public class Feet : BaseUnitOfMeasurementModel
    {
        public static readonly Lazy<Feet> InstanceHolder = new Lazy<Feet>(() => new Feet());

        Feet() : base(UnitOfMeasurement.Length)
        {
        }

        public static Feet Instance => InstanceHolder.Value;

        public override double ConvertFromBaseUnits(double valueInMeters) => Converter.MetersToInternationalFeet(valueInMeters);

        public override double ConvertToBaseUnits(double valueInFeet) => Converter.InternationalFeetToMeters(valueInFeet);
    }
}
