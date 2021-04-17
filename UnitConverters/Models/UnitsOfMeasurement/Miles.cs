using System;
using UnitConverters.Models.Base;
using UnitConverters.Service;

namespace UnitConverters.Models.UnitsOfMeasurement
{
    public class Miles : BaseUnitOfMeasurementModel
    {
        public static readonly Lazy<Miles> InstanceHolder = new Lazy<Miles>(() => new Miles());

        Miles() : base(UnitOfMeasurement.Length)
        {
        }

        public static Miles Instance => InstanceHolder.Value;

        public override double ConvertFromBaseUnits(double valueInMeters) => Converter.KilometersToMiles(valueInMeters / 1000);

        public override double ConvertToBaseUnits(double valueInMilies) => Converter.MilesToKilometers(valueInMilies) * 1000;
    }
}
