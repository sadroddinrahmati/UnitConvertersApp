using System;
using UnitConverters.Models.Base;
using UnitConverters.Service;

namespace UnitConverters.Models.UnitsOfMeasurement
{
    public class Pounds : BaseUnitOfMeasurementModel
    {
        public static readonly Lazy<Pounds> InstanceHolder = new(() => new Pounds());

        private Pounds() : base(UnitOfMeasurement.Mass) { }

        public static Pounds Instance => InstanceHolder.Value;

        public override double ConvertFromBaseUnits(double unitsInGrams) => Converter.KilogramsToPounds(unitsInGrams / 1000);

        public override double ConvertToBaseUnits(double unitsInPounds) => Converter.PoundsToKilograms(unitsInPounds) * 1000;
    }
}
