using System;

namespace ProjektUppgiftGIK299
{
    // Klassen TemperatureConverter hanterar konvertering mellan olika temperatur-enheter.
    public class TemperatureConverter
    {
        // Konverterar temperatur från Celsius till Fahrenheit.
        public double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        // Konverterar temperatur från Fahrenheit till Celsius.
        public double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        // Konverterar temperatur från Celsius till Kelvin.
        public double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        // Konverterar temperatur från Kelvin till Celsius.
        public double KelvinToCelsius(double kelvin)
        {
            return kelvin - 273.15;
        }
    }
}
