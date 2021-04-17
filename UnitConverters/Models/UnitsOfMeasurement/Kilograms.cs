using System;
using UnitConverters.Models.Base;

namespace UnitConverters.Models.UnitsOfMeasurement
{
    public class Kilograms : BaseUnitOfMeasurementModel
    {
        public static readonly Lazy<Kilograms> InstanceHolder = new Lazy<Kilograms>(() => new Kilograms());

        Kilograms() : base(UnitOfMeasurement.Mass)
        {
        }

        public static Kilograms Instance => InstanceHolder.Value;

        public override double ConvertFromBaseUnits(double numberInGrams) => numberInGrams / 1000;

        public override double ConvertToBaseUnits(double numberInKilograms) => numberInKilograms * 1000;
    }
}
