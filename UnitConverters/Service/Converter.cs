namespace UnitConverters.Service
{
    public static class Converter
    { 
        const double milesToKilometers = 1.609344; 
        const double kilometersToMiles = 1.0 / milesToKilometers;
        const double celsiusToKelvin = 273.15;
        const double poundsToKg = 0.45359237; 
        const double kgToPounds = 2.204623;  
        const double internationalFootDefinition = 0.3048; 

        public static double FahrenheitToCelsius(double fahrenheit) => (fahrenheit - 32.0) / 1.8;

        public static double CelsiusToFahrenheit(double celsius) => (celsius * 1.8) + 32.0;

        public static double CelsiusToKelvin(double celsius) => celsius + celsiusToKelvin;

        public static double KelvinToCelsius(double kelvin) => kelvin - celsiusToKelvin;

        public static double MilesToKilometers(double miles) => miles * milesToKilometers;

        public static double KilometersToMiles(double kilometers) => kilometers * kilometersToMiles;
          
        public static double PoundsToKilograms(double pounds) => pounds * poundsToKg;
        
        public static double KilogramsToPounds(double kilograms) => kilograms * kgToPounds;
        
        public static double MetersToInternationalFeet(double meters) => meters / internationalFootDefinition;
        
        public static double InternationalFeetToMeters(double internationalFeet) => internationalFeet * internationalFootDefinition;
    }
}
