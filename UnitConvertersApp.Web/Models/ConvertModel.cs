using System.ComponentModel.DataAnnotations;

namespace UnitConvertersApp.Web.Models
{
    public class ConvertModel
    {  
        [Required]
        public string NumberToConvert { get; set; }
        public string OriginalUnits { get; set; }
        public string ConvertedUnits { get; set; }
    }
}
