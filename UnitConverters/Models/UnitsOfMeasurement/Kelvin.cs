using System;
using UnitConverters.Models.Base;

namespace UnitConverters.Models.UnitsOfMeasurement
{
    public class Kelvin : BaseUnitOfMeasurementModel
    {
        public static readonly Lazy<Kelvin> InstanceHolder = new Lazy<Kelvin>(() => new Kelvin());

        Kelvin() : base(UnitOfMeasurement.Temperature)
        {
        }

        public static Kelvin Instance => InstanceHolder.Value;

        public override double ConvertFromBaseUnits(double unitsInKelvin) => unitsInKelvin;

        public override double ConvertToBaseUnits(double unitsInKelvin) => unitsInKelvin;
    }
}
