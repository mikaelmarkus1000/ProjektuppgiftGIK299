using System;

namespace ProjektUppgiftGIK299
{
    // Klassen WeightConverter hanterar konvertering mellan olika viktenheter.
    public class WeightConverter
    {
        // Konverterar vikten från pund till uns.
        public double PoundsToOunces(double pounds)
        {
            return pounds * 16;
        }

        // Konverterar vikten från uns till pund.
        public double OuncesToPounds(double ounces)
        {
            return ounces / 16;
        }

       public double PoundsToKilograms(double pounds)
        {
            return pounds / 2.2046;
        }

        public double KilogramsToPounds(double kilograms)
        {
            return kilograms * 2.2046;
        }
    }
}
