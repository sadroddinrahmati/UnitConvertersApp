using System;
using UnitConverters.Models.Base;
using UnitConverters.Service;

namespace UnitConverters.Models.UnitsOfMeasurement
{
    public class Ounces : BaseUnitOfMeasurementModel
    {
        public static readonly Lazy<Ounces> InstanceHolder = new Lazy<Ounces>(() => new Ounces());

        Ounces() : base(UnitOfMeasurement.Mass)
        {
        }

        public static Ounces Instance => InstanceHolder.Value;

        public override double ConvertFromBaseUnits(double numberInGrams) => Converter.KilogramsToPounds(numberInGrams / 1000) * 16;

        public override double ConvertToBaseUnits(double numberInOunces) => Converter.PoundsToKilograms(numberInOunces / 16) * 1000;
    }
}
