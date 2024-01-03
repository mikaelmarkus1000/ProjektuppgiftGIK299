using ProjektuppgiftGIK299;

namespace ProjektUppgiftGIK299
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                Console.WriteLine("Meny");
                Console.WriteLine("1. Längd");
                Console.WriteLine("2. Vikt");
                Console.WriteLine("3. Temperatur");
                Console.WriteLine("4. Avsluta");
                Console.WriteLine("Välj ett alternativ: ");
                string input = Console.ReadLine();


                switch (input)
                {
                    case "1":
                        Console.WriteLine("Vilka längdenheter vill du konvertera?");
                        Console.WriteLine("1. Tum till fot");
                        Console.WriteLine("2. Fot till yard");
                        Console.WriteLine("3. Yard till meter");
                        Console.WriteLine("4. Meter till yard");
                        Console.WriteLine("5. Mile till kilometer");
                        Console.WriteLine("6. Kilometer till mile");
                        Console.WriteLine("7. Meter till centimeter");
                        Console.WriteLine("8. Centimeter till meter");
                        Console.WriteLine("9. Meter till kilometer");
                        Console.WriteLine("10. Kilometer till meter");
                        Console.WriteLine("11. Avsluta");
                        Console.WriteLine("Välj ett alternativ: ");
                        string input1 = Console.ReadLine();
                        switch (input1)
                        {
                            case "1":
                                // Tum till fot
                                Console.WriteLine("Skriv in antal tum: ");
                                double inches = double.Parse(Console.ReadLine());
                                LengthConverter lengthConverter = new LengthConverter();
                                double feet = lengthConverter.InchesToFeet(inches);
                                Console.WriteLine($" {inches} tum är {feet} fot.");
                                Console.WriteLine("");
                                break;
                            case "2":
                                // Fot till yard
                                Console.WriteLine("Skriv in antal fot: ");
                                double feet2 = double.Parse(Console.ReadLine());
                                LengthConverter lengthConverter2 = new LengthConverter();
                                double yards = lengthConverter2.FeetToYards(feet2);
                                Console.WriteLine($" {feet2} fot är {yards} yard.");
                                Console.WriteLine("");
                                break;

                            case "3":
                                // Yard till meter
                                Console.WriteLine("Skriv in antal yard: ");
                                double yards2 = double.Parse(Console.ReadLine());
                                LengthConverter lengthConverter3 = new LengthConverter();
                                double meters = lengthConverter3.YardsToMeters(yards2);
                                Console.WriteLine($" {yards2} yard är {meters} meter.");
                                Console.WriteLine("");
                                break;
                            case "4":
                                // Meter till yard
                                Console.WriteLine("Skriv in antal meter: ");
                                double meters2 = double.Parse(Console.ReadLine());
                                LengthConverter lengthConverter4 = new LengthConverter();
                                double yards3 = lengthConverter4.MetersToYards(meters2);
                                Console.WriteLine($" {meters2} meter är {yards3} yard.");
                                Console.WriteLine("");
                                break;
                            case "5":
                                // Mile till kilometer
                                Console.WriteLine("Skriv in antal mile: ");
                                double miles = double.Parse(Console.ReadLine());
                                LengthConverter lengthConverter5 = new LengthConverter();
                                double kilometers = lengthConverter5.MilesToKilometers(miles);
                                Console.WriteLine($" {miles} mile är {kilometers} kilometer.");
                                Console.WriteLine("");
                                break;
                            case "6":
                                // Kilometer till mile
                                Console.WriteLine("Skriv in antal kilometer: ");
                                double kilometers2 = double.Parse(Console.ReadLine());
                                LengthConverter lengthConverter6 = new LengthConverter();
                                double miles2 = lengthConverter6.KilometersToMiles(kilometers2);
                                Console.WriteLine($" {kilometers2} kilometer är {miles2} mile.");
                                break;
                            case "7":
                                // Meter till centimeter
                                Console.WriteLine("Skriv in antal meter: ");
                                double meters3 = double.Parse(Console.ReadLine());
                                LengthConverter lengthConverter7 = new LengthConverter();
                                double centimeters = lengthConverter7.MetersToCentimeters(meters3);
                                Console.WriteLine($" {meters3} meter är {centimeters} centimeter.");
                                Console.WriteLine("");
                                break;
                            case "8":
                                // Centimeter till meter
                                Console.WriteLine("Skriv in antal centimeter: ");
                                double centimeters2 = double.Parse(Console.ReadLine());
                                LengthConverter lengthConverter8 = new LengthConverter();
                                double meters4 = lengthConverter8.CentimetersToMeters(centimeters2);
                                Console.WriteLine($" {centimeters2} centimeter är {meters4} meter.");
                                Console.WriteLine("");
                                break;
                            case "9":
                                // Meter till kilometer
                                Console.WriteLine("Skriv in antal meter: ");
                                double meters5 = double.Parse(Console.ReadLine());
                                LengthConverter lengthConverter9 = new LengthConverter();
                                double kilometers3 = lengthConverter9.MetersToKilometers(meters5);
                                Console.WriteLine($" {meters5} meter är {kilometers3} kilometer.");
                                Console.WriteLine("");
                                break;
                            case "10":
                                // Kilometer till meter
                                Console.WriteLine("Skriv in antal kilometer: ");
                                double kilometers4 = double.Parse(Console.ReadLine());
                                LengthConverter lengthConverter10 = new LengthConverter();
                                double meters6 = lengthConverter10.KilometersToMeters(kilometers4);
                                Console.WriteLine($" {kilometers4} kilometer är {meters6} meter.");
                                Console.WriteLine("");
                                break;
                            case "11":
                                return;
                                break;
                        }
                        break;
                    case "2":
                        Console.WriteLine("Vilka viktenheter vill du konvertera?");
                        Console.WriteLine("1. Pund till uns");
                        Console.WriteLine("2. Uns till pund");
                        Console.WriteLine("3. Pund till kilogram");
                        Console.WriteLine("4. Kilogram till pund");
                        Console.WriteLine("5. Avsluta");
                        Console.WriteLine("Välj ett alternativ: ");
                        string input2 = Console.ReadLine();

                        switch (input2)
                        {
                            case "1":
                                // Pund till uns
                                Console.WriteLine("Skriv in antal pund: ");
                                double pounds = double.Parse(Console.ReadLine());
                                WeightConverter weightConverter = new WeightConverter();
                                double ounces = weightConverter.PoundsToOunces(pounds);
                                Console.WriteLine($" {pounds} pund är {ounces} uns.");
                                Console.WriteLine("");
                                break;
                            case "2":
                                // Uns till pund
                                Console.WriteLine("Skriv in antal uns: ");
                                double ounces2 = double.Parse(Console.ReadLine());
                                WeightConverter weightConverter2 = new WeightConverter();
                                double pounds2 = weightConverter2.OuncesToPounds(ounces2);
                                Console.WriteLine($" {ounces2} uns är {pounds2} pund.");
                                Console.WriteLine("");
                                break;

                            case "3":
                                // Pund till kilogram
                                Console.WriteLine("Skriv in antal pund: ");
                                double pounds3 = double.Parse(Console.ReadLine());
                                WeightConverter weightConverter3 = new WeightConverter();
                                double kilograms = weightConverter3.PoundsToKilograms(pounds3);
                                Console.WriteLine($" {pounds3} pund är {kilograms} kilogram.");
                                Console.WriteLine("");
                                break;
                            case "4":
                                // Kilogram till pund
                                Console.WriteLine("Skriv in antal kilogram: ");
                                double kilograms2 = double.Parse(Console.ReadLine());
                                WeightConverter weightConverter4 = new WeightConverter();
                                double pounds4 = weightConverter4.KilogramsToPounds(kilograms2);
                                Console.WriteLine($" {kilograms2} kilogram är {pounds4} pund.");
                                Console.WriteLine("");
                                break;
                            case "5":
                                return;
                                break;
                        }




                        break;
                    case "3":
                        Console.WriteLine("Vilka temperaturskalor vill du konvertera?");
                        Console.WriteLine("1. Celsius till Fahrenheit");
                        Console.WriteLine("2. Fahrenheit till Celsius");
                        Console.WriteLine("3. Celsius till Kelvin");
                        Console.WriteLine("4. Kelvin till Celsius");
                        Console.WriteLine("5. Avsluta");
                        Console.WriteLine("Välj ett alternativ: ");
                        string input3 = Console.ReadLine();
                        switch (input3)
                        {
                            case "1":
                                // Celsius till Fahrenheit
                                Console.WriteLine("Skriv in antal grader Celsius: ");
                                double celsius = double.Parse(Console.ReadLine());
                                TemperatureConverter temperatureConverter = new TemperatureConverter();
                                double fahrenheit = temperatureConverter.CelsiusToFahrenheit(celsius);
                                Console.WriteLine($" {celsius} grader Celsius är {fahrenheit} grader Fahrenheit.");
                                Console.WriteLine("");
                                break;
                            case "2":
                                // Fahrenheit till Celsius
                                Console.WriteLine("Skriv in antal grader Fahrenheit: ");
                                double fahrenheit2 = double.Parse(Console.ReadLine());
                                TemperatureConverter temperatureConverter2 = new TemperatureConverter();
                                double celsius2 = temperatureConverter2.FahrenheitToCelsius(fahrenheit2);
                                Console.WriteLine($" {fahrenheit2} grader Fahrenheit är {celsius2} grader Celsius.");
                                Console.WriteLine("");
                                break;
                            case "3":
                                // Celsius till Kelvin
                                Console.WriteLine("Skriv in antal grader Celsius: ");
                                double celsius3 = double.Parse(Console.ReadLine());
                                TemperatureConverter temperatureConverter3 = new TemperatureConverter();
                                double kelvin = temperatureConverter3.CelsiusToKelvin(celsius3);
                                Console.WriteLine($" {celsius3} grader Celsius är {kelvin} grader Kelvin.");
                                Console.WriteLine("");
                                break;
                            case "4":
                                // Kelvin till Celsius
                                Console.WriteLine("Skriv in antal grader Kelvin: ");
                                double kelvin2 = double.Parse(Console.ReadLine());
                                TemperatureConverter temperatureConverter4 = new TemperatureConverter();
                                double celsius4 = temperatureConverter4.KelvinToCelsius(kelvin2);
                                Console.WriteLine($" {kelvin2} grader Kelvin är {celsius4} grader Celsius.");
                                Console.WriteLine("");
                                break;
                            case "5":
                                return;
                                break;


                        }

                        break;
                    case "4":
                        Environment.Exit(0);
                        break;


                }





            }







        }
    }
}