using System.Collections.Generic;
using System.Linq;
using UnitConverters.Models.Base;
using UnitConverters.Models.UnitsOfMeasurement;
using UnitConvertersApp.Web.Models;

namespace UnitConvertersApp.Web.Service
{
    public class ConverterService
    {
        private static readonly IReadOnlyDictionary<string, BaseUnitOfMeasurementModel> UnitOfMeasurementDictionary
            = new Dictionary<string, BaseUnitOfMeasurementModel>
            {
                { nameof(Celsius), Celsius.Instance },
                { nameof(Fahrenheit), Fahrenheit.Instance },
                { nameof(Feet), Feet.Instance },
                { nameof(Kelvin), Kelvin.Instance },
                { nameof(Kilograms), Kilograms.Instance },
                { nameof(Kilometers), Kilometers.Instance },
                { nameof(Meters), Meters.Instance },
                { nameof(Ounces), Ounces.Instance },
                { nameof(Miles), Miles.Instance },
                { nameof(Pounds), Pounds.Instance },
                { nameof(Yards), Yards.Instance }
            };

        public string ConvertUnits(ConvertModel model)
        {
            try
            {
                var firstItemSelectedType = UnitOfMeasurementDictionary[model.OriginalUnits];
                var secondItemSelectedType = UnitOfMeasurementDictionary[model.ConvertedUnits];

                var inputAsBaseUnits = firstItemSelectedType.ConvertToBaseUnits(double.Parse(model.NumberToConvert));

                var inputAsConvertedUnits = secondItemSelectedType.ConvertFromBaseUnits(inputAsBaseUnits);
                return $"{model.NumberToConvert} {model.OriginalUnits} = {inputAsConvertedUnits} {model.ConvertedUnits}";
            }
            catch
            {
                return string.Empty;
            }
        }

        public List<string> PopulateUnitsLists(UnitOfMeasurement unitOfMeasurement)
        {
            var unitsList = new List<string>(); 

            var listOfSelectedUnits =
                UnitOfMeasurementDictionary.Where(x => 
                    x.Value.MeasurementType.Equals(unitOfMeasurement));

            foreach (var item in listOfSelectedUnits)
            {
                unitsList.Add(item.Key); 
            }

            return unitsList; 
        }

    }
}
