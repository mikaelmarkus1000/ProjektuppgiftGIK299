using System;

namespace ProjektuppgiftGIK299
{
    // Klassen LengthConverter hanterar konvertering mellan olika längdenheter.
    public class LengthConverter
    {
        // Konverterar längden från tum till fot.
        public double InchesToFeet(double inches)
        {
            return inches / 12;
        }

        // Konverterar längden från fot till yard.
        public double FeetToYards(double feet)
        {
            return feet / 3;
        }

        public double YardsToMeters(double yards)
        {
            return yards * 0.9144;
        }

        // Konverterar meter till yards.
        public double MetersToYards(double meters)
        {
            return meters / 0.9144;
        }

        // Konverterar miles till kilometer.
        public double MilesToKilometers(double miles)
        {
            return miles * 1.60934;
        }

        // Konverterar kilometer till miles.
        public double KilometersToMiles(double kilometers)
        {
            return kilometers / 1.60934;
        }

        // Konverterar meter till centimeter.
        public double MetersToCentimeters(double meters)
        {
            return meters * 100;
        }

        // Konverterar centimeter till meter.
        public double CentimetersToMeters(double centimeters)
        {
            return centimeters / 100;
        }

        // Konverterar meter till kilometer.
        public double MetersToKilometers(double meters)
        {
            return meters / 1000;
        }

        // Konverterar kilometer till meter.
        public double KilometersToMeters(double kilometers)
        {
            return kilometers * 1000;
        }
    }
}
