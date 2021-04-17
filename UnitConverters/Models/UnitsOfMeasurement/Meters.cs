using System;
using UnitConverters.Models.Base;

namespace UnitConverters.Models.UnitsOfMeasurement
{
    public class Meters : BaseUnitOfMeasurementModel
    {
        public static readonly Lazy<Meters> InstanceHolder = new Lazy<Meters>(() => new Meters());

        Meters() : base(UnitOfMeasurement.Length)
        {
        }

        public static Meters Instance => InstanceHolder.Value;

        public override double ConvertFromBaseUnits(double valueInMeters) => valueInMeters;

        public override double ConvertToBaseUnits(double valueInMeters) => valueInMeters;
    }
}
