using System;
using UnitConverters.Models.Base;
using UnitConverters.Service;

namespace UnitConverters.Models.UnitsOfMeasurement
{
    public class Yards : BaseUnitOfMeasurementModel
    {
        public static readonly Lazy<Yards> InstanceHolder = new(() => new Yards());

        private Yards() : base(UnitOfMeasurement.Length) { }

        public static Yards Instance => InstanceHolder.Value;

        public override double ConvertFromBaseUnits(double unitInMeters) => Converter.MetersToInternationalFeet(unitInMeters) / 3;

        public override double ConvertToBaseUnits(double unitInYards) => Converter.InternationalFeetToMeters(unitInYards * 3);
    }
}
