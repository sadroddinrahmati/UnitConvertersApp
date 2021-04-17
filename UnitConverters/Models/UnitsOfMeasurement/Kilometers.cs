using System;
using UnitConverters.Models.Base;

namespace UnitConverters.Models.UnitsOfMeasurement
{
    public class Kilometers : BaseUnitOfMeasurementModel
    {
        public static readonly Lazy<Kilometers> InstanceHolder = new Lazy<Kilometers>(() => new Kilometers());

        Kilometers() : base(UnitOfMeasurement.Length)
        {
        }

        public static Kilometers Instance => InstanceHolder.Value;

        public override double ConvertFromBaseUnits(double valueInMeters) => valueInMeters / 1000;

        public override double ConvertToBaseUnits(double valueInKilometers) => valueInKilometers * 1000;
    }
}
