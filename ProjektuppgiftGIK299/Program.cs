using ProjektuppgiftGIK299;
using System.Linq.Expressions;

namespace ProjektUppgiftGIK299
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Välkommen till konverteraren!");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Var god och välj ett konveteringsval.");
                Console.WriteLine("---------------------------------------");
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
                                try
                                {
                                    Console.WriteLine("Skriv in antal tum: ");
                                    double inches = double.Parse(Console.ReadLine());
                                    LengthConverter lengthConverter = new LengthConverter();
                                    double feet = lengthConverter.InchesToFeet(inches);
                                    string result = $"{inches:F2} tum är {feet:F2} fot.";

                                    // Skriv ut resultatet till konsolen
                                    Console.WriteLine(result);

                                    // Skriv ut resultatet till en fil
                                    string filePath = "conversion_log.txt";
                                    File.AppendAllText(filePath, $"{DateTime.Now}: {result}{Environment.NewLine}");
                                    Console.WriteLine("Resultatet har sparats till filen.");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    // Skriv undantaget till samma fil
                                    string filePath = "conversion_log.txt";
                                    File.AppendAllText(filePath, $"{DateTime.Now}: Error - {ex.Message}{Environment.NewLine}");
                                    Console.WriteLine("Ett fel loggades till filen.");
                                }

                                break;



                            case "2":
                                try
                                {
                                    // Fot till yard
                                    Console.WriteLine("Skriv in antal fot: ");
                                    double feet2 = double.Parse(Console.ReadLine());
                                    LengthConverter lengthConverter2 = new LengthConverter();
                                    double yards = lengthConverter2.FeetToYards(feet2);
                                    string result = $" {feet2:F2} fot är {yards:F2} yard.";

                                    // Skriv ut resultatet till konsolen
                                    Console.WriteLine(result);

                                    // Skriv ut resultatet till en fil
                                    string filePath = "conversion_log.txt";
                                    File.AppendAllText(filePath, $"{DateTime.Now}: {result}{Environment.NewLine}");
                                    Console.WriteLine("Resultatet har sparats till filen.");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    // Skriv undantaget till samma fil
                                    string filePath = "conversion_log.txt";
                                    File.AppendAllText(filePath, $"{DateTime.Now}: Error - {ex.Message}{Environment.NewLine}");
                                    Console.WriteLine("Ett fel loggades till filen.");
                                }

                                break;

                            case "3":
                                try
                                {
                                    // Yard till meter
                                    Console.WriteLine("Skriv in antal yard: ");
                                    double yards2 = double.Parse(Console.ReadLine());
                                    LengthConverter lengthConverter3 = new LengthConverter();
                                    double meters = lengthConverter3.YardsToMeters(yards2);
                                    string result = $" {yards2:F2} yard är {meters:F2} meter.";

                                    // Skriv ut resultatet till konsolen
                                    Console.WriteLine(result);

                                    // Skriv ut resultatet till en fil
                                    string filePath = "conversion_log.txt";
                                    File.AppendAllText(filePath, $"{DateTime.Now}: {result}{Environment.NewLine}");
                                    Console.WriteLine("Resultatet har sparats till filen.");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    // Skriv undantaget till samma fil
                                    string filePath = "conversion_log.txt";
                                    File.AppendAllText(filePath, $"{DateTime.Now}: Error - {ex.Message}{Environment.NewLine}");
                                    Console.WriteLine("Ett fel loggades till filen.");
                                }
                                break;

                            case "4":
                                // Meter till yard
                                try
                                {
                                    Console.WriteLine("Skriv in antal meter: ");
                                    double meters2 = double.Parse(Console.ReadLine());
                                    LengthConverter lengthConverter4 = new LengthConverter();
                                    double yards3 = lengthConverter4.MetersToYards(meters2);
                                    string result = $" {meters2:F2} meter är {yards3:F2} yard.";

                                    // Skriv ut resultatet till konsolen
                                    Console.WriteLine(result);

                                    // Skriv ut resultatet till en fil
                                    string filePath = "conversion_log.txt";
                                    File.AppendAllText(filePath, $"{DateTime.Now}: {result}{Environment.NewLine}");
                                    Console.WriteLine("Resultatet har sparats till filen.");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    // Skriv undantaget till samma fil
                                    string filePath = "conversion_log.txt";
                                    File.AppendAllText(filePath, $"{DateTime.Now}: Error - {ex.Message}{Environment.NewLine}");
                                    Console.WriteLine("Ett fel loggades till filen.");
                                }
                                break;

                            case "5":
                                try
                                {
                                    // Mile till kilometer
                                    Console.WriteLine("Skriv in antal mile: ");
                                    double miles = double.Parse(Console.ReadLine());
                                    LengthConverter lengthConverter5 = new LengthConverter();
                                    double kilometers = lengthConverter5.MilesToKilometers(miles);
                                    string result = $" {miles:F2} mile är {kilometers:F2} kilometer.";

                                    // Skriv ut resultatet till konsolen
                                    Console.WriteLine(result);

                                    // Skriv ut resultatet till en fil
                                    string filePath = "conversion_log.txt";
                                    File.AppendAllText(filePath, $"{DateTime.Now}: {result}{Environment.NewLine}");
                                    Console.WriteLine("Resultatet har sparats till filen.");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    // Skriv undantaget till samma fil
                                    string filePath = "conversion_log.txt";
                                    File.AppendAllText(filePath, $"{DateTime.Now}: Error - {ex.Message}{Environment.NewLine}");
                                    Console.WriteLine("Ett fel loggades till filen.");
                                }
                                break;


                            case "6":
                                try
                                {
                                    // Kilometer till mile
                                    Console.WriteLine("Skriv in antal kilometer: ");
                                    double kilometers2 = double.Parse(Console.ReadLine());
                                    LengthConverter lengthConverter6 = new LengthConverter();
                                    double miles2 = lengthConverter6.KilometersToMiles(kilometers2);
                                    string result = $" {kilometers2:F2} kilometer är {miles2:F2} mile.";

                                    // Skriv ut resultatet till konsolen
                                    Console.WriteLine(result);

                                    // Skriv ut resultatet till en fil
                                    string filePath = "conversion_log.txt";
                                    File.AppendAllText(filePath, $"{DateTime.Now}: {result}{Environment.NewLine}");
                                    Console.WriteLine("Resultatet har sparats till filen.");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    // Skriv undantaget till samma fil
                                    string filePath = "conversion_log.txt";
                                    File.AppendAllText(filePath, $"{DateTime.Now}: Error - {ex.Message}{Environment.NewLine}");
                                    Console.WriteLine("Ett fel loggades till filen.");
                                }

                                break;

                            case "7":
                                try
                                {
                                    // Meter till centimeter
                                    Console.WriteLine("Skriv in antal meter: ");
                                    double meters3 = double.Parse(Console.ReadLine());
                                    LengthConverter lengthConverter7 = new LengthConverter();
                                    double centimeters = lengthConverter7.MetersToCentimeters(meters3);
                                    string result = $" {meters3:F2} meter är {centimeters:F2} centimeter.";

                                    // Skriv ut resultatet till konsolen
                                    Console.WriteLine(result);

                                    // Skriv ut resultatet till en fil
                                    string filePath = "conversion_log.txt";
                                    File.AppendAllText(filePath, $"{DateTime.Now}: {result}{Environment.NewLine}");
                                    Console.WriteLine("Resultatet har sparats till filen.");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    // Skriv undantaget till samma fil
                                    string filePath = "conversion_log.txt";
                                    File.AppendAllText(filePath, $"{DateTime.Now}: Error - {ex.Message}{Environment.NewLine}");
                                    Console.WriteLine("Ett fel loggades till filen.");
                                }

                                break;


                            case "8":
                                try
                                {
                                    // Centimeter till meter
                                    Console.WriteLine("Skriv in antal centimeter: ");
                                    double centimeters2 = double.Parse(Console.ReadLine());
                                    LengthConverter lengthConverter8 = new LengthConverter();
                                    double meters4 = lengthConverter8.CentimetersToMeters(centimeters2);
                                    string result = $" {centimeters2:F2} centimeter är {meters4:F2} meter.";

                                    // Skriv ut resultatet till konsolen
                                    Console.WriteLine(result);



                                    string filePath = "conversion_log.txt";
                                    File.AppendAllText(filePath, $"{DateTime.Now}: {result}{Environment.NewLine}");
                                    Console.WriteLine("Resultatet har sparats till filen.");

                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    string filePath = "conversion_log.txt";
                                    File.AppendAllText(filePath, $"{DateTime.Now}: Error - {ex.Message}{Environment.NewLine}");
                                    Console.WriteLine("Ett fel loggades till filen.");



                                }

                                break;

                            case "9":
                                try
                                {


                                    // Meter till kilometer
                                    Console.WriteLine("Skriv in antal meter: ");
                                    double meters5 = double.Parse(Console.ReadLine());
                                    LengthConverter lengthConverter9 = new LengthConverter();
                                    double kilometers3 = lengthConverter9.MetersToKilometers(meters5);
                                    string result = $" {meters5} meter är {kilometers3} kilometer.";
                                    Console.WriteLine(result);

                                    string filePath = "conversion_logs.txt";
                                    File.AppendAllText(filePath, $"{DateTime.Now}: {result}{Environment.NewLine}");
                                    Console.WriteLine("File saved");
                                }

                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    string filePath = "conversion_log.txt";
                                    File.AppendAllText(filePath, $"{DateTime.Now}: Error - {ex.Message}{Environment.NewLine}");
                                    Console.WriteLine("Ett fel loggades till filen.");

                                }

                                break;

                            case "10":
                                // Kilometer till meter
                                try
                                {

                                    Console.WriteLine("Skriv in antal kilometer: ");
                                    double kilometers4 = double.Parse(Console.ReadLine());
                                    LengthConverter lengthConverter10 = new LengthConverter();
                                    double meters6 = lengthConverter10.KilometersToMeters(kilometers4);

                                    string result = $"{kilometers4:F2} kilometer är {meters6:F2} meter";

                                    Console.WriteLine(result);
                                    string filePath = "conversion_logs.txt";
                                    File.AppendAllText(filePath, $"{DateTime.Now}: {result}{Environment.NewLine}");
                                    Console.WriteLine("File saved");


                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    string filePath = "conversion_log.txt";
                                    File.AppendAllText(filePath, $"{DateTime.Now}: Error - {ex.Message}{Environment.NewLine}");
                                    Console.WriteLine("Ett fel loggades till filen.");
                                }
                                break;




                            case "11":
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Felaktig inmatning, försök igen.");
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
                                try
                                {
                                    Console.WriteLine("Skriv in antal pund: ");
                                    double pounds = double.Parse(Console.ReadLine());
                                    WeightConverter weightConverter = new WeightConverter();
                                    double ounces = weightConverter.PoundsToOunces(pounds);
                                    string result = $" {pounds:F2} pund är {ounces:F2} uns.";

                                    // Skriv ut resultatet till konsolen
                                    Console.WriteLine(result);

                                    // Skriv ut resultatet till filen med tidsstämpel
                                    string filePath = "conversion_log.txt";
                                    string logMessage = $"{DateTime.Now}: {result}{Environment.NewLine}";
                                    File.AppendAllText(filePath, logMessage);
                                    Console.WriteLine("Resultatet har sparats till filen.");
                                }
                                catch (Exception ex)
                                {
                                    // Skriv ut felmeddelandet till konsolen
                                    Console.WriteLine(ex.Message);

                                    // Skriv ut felmeddelandet till samma fil som resultat med tidsstämpel
                                    string filePath = "conversion_log.txt";
                                    string logMessage = $"{DateTime.Now}: Error - {ex.Message}{Environment.NewLine}";
                                    File.AppendAllText(filePath, logMessage);
                                    Console.WriteLine("Ett fel loggades till filen.");
                                }
                                break;


                            case "2":
                                try
                                {
                                    // Uns till pund
                                    Console.WriteLine("Skriv in antal uns: ");
                                    double ounces2 = double.Parse(Console.ReadLine());
                                    WeightConverter weightConverter2 = new WeightConverter();
                                    double pounds2 = weightConverter2.OuncesToPounds(ounces2);
                                    string result = $" {ounces2:F2} uns är {pounds2:F2} pund.";

                                    // Skriv ut resultatet till konsolen
                                    Console.WriteLine(result);

                                    // Skriv ut resultatet till en fil
                                    string filePath = "conversion_log.txt";
                                    File.AppendAllText(filePath, $"{DateTime.Now}: {result}{Environment.NewLine}");
                                    Console.WriteLine("Resultatet har sparats till filen.");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    // Skriv undantaget till samma fil
                                    string filePath = "conversion_log.txt";
                                    File.AppendAllText(filePath, $"{DateTime.Now}: Error - {ex.Message}{Environment.NewLine}");
                                    Console.WriteLine("Ett fel loggades till filen.");
                                }

                                break;


                            case "3":
                                try
                                {
                                    // Pund till kilogram
                                    Console.WriteLine("Skriv in antal pund: ");
                                    double pounds3 = double.Parse(Console.ReadLine());
                                    WeightConverter weightConverter3 = new WeightConverter();
                                    double kilograms = weightConverter3.PoundsToKilograms(pounds3);
                                    string result = $" {pounds3:F2} pund är {kilograms:F2} kilogram.";

                                    // Skriv ut resultatet till konsolen
                                    Console.WriteLine(result);

                                    // Skriv ut resultatet till en fil
                                    string filePath = "conversion_log.txt";
                                    File.AppendAllText(filePath, $"{DateTime.Now}: {result}{Environment.NewLine}");
                                    Console.WriteLine("Resultatet har sparats till filen.");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    // Skriv undantaget till samma fil
                                    string filePath = "conversion_log.txt";
                                    File.AppendAllText(filePath, $"{DateTime.Now}: Error - {ex.Message}{Environment.NewLine}");
                                    Console.WriteLine("Ett fel loggades till filen.");
                                }

                                break;


                            case "4":
                                try
                                {
                                    // Kilogram till pund
                                    Console.WriteLine("Skriv in antal kilogram: ");
                                    double kilograms2 = double.Parse(Console.ReadLine());
                                    WeightConverter weightConverter4 = new WeightConverter();
                                    double pounds4 = weightConverter4.KilogramsToPounds(kilograms2);
                                    string result = $" {kilograms2:F2} kilogram är {pounds4:F2} pund.";

                                    // Skriv ut resultatet till konsolen
                                    Console.WriteLine(result);

                                    // Skriv ut resultatet till en fil
                                    string filePath = "conversion_log.txt";
                                    File.AppendAllText(filePath, $"{DateTime.Now}: {result}{Environment.NewLine}");
                                    Console.WriteLine("Resultatet har sparats till filen.");
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                    // Skriv undantaget till samma fil
                                    string filePath = "conversion_log.txt";
                                    File.AppendAllText(filePath, $"{DateTime.Now}: Error - {ex.Message}{Environment.NewLine}");
                                    Console.WriteLine("Ett fel loggades till filen.");
                                }
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
                                try
                                {
                                    // Celsius till Fahrenheit
                                    Console.WriteLine("Skriv in antal grader Celsius: ");
                                    double celsius = double.Parse(Console.ReadLine());
                                    TemperatureConverter temperatureConverter = new TemperatureConverter();
                                    double fahrenheit = temperatureConverter.CelsiusToFahrenheit(celsius);
                                    string result = $" {celsius:F2}  grader Celsius är  {fahrenheit:F2} grader Fahrenheit.";
                                    // Skriv ut resultatet till konsolen 
                                    Console.WriteLine(result);
                                    // Skriv ut resultatet till filen med tidsstämpel
                                    string filePath = "conversion_logs.txt";
                                    File.AppendAllText(filePath, $"{DateTime.Now}: {result}{Environment.NewLine}");
                                    Console.WriteLine("Resultatet har sparats till filen.");

                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);

                                }
                                break;


                            case "2":
                                try
                                {
                                    // Fahrenheit till Celsius
                                    Console.WriteLine("Skriv in antal grader Fahrenheit: ");
                                    double fahrenheit2 = double.Parse(Console.ReadLine());
                                    TemperatureConverter temperatureConverter2 = new TemperatureConverter();
                                    double celsius2 = temperatureConverter2.FahrenheitToCelsius(fahrenheit2);
                                    string result = $" {fahrenheit2:F2}  grader Fahrenheit är  {celsius2:F2} grader Celsius.";

                                    // Skriv ut resultatet till konsolen
                                    Console.WriteLine(result);

                                    // Skriv ut resultatet till filen med tidsstämpel
                                    string filePath = "conversion_log.txt";
                                    string logMessage = $"{DateTime.Now}: {result}{Environment.NewLine}";
                                    File.AppendAllText(filePath, logMessage);
                                    Console.WriteLine("Resultatet har sparats till filen.");
                                }
                                catch (Exception ex)
                                {
                                    // Skriv ut felmeddelandet till konsolen
                                    Console.WriteLine(ex.Message);

                                    // Skriv ut felmeddelandet till samma fil som resultat med tidsstämpel
                                    string filePath = "conversion_log.txt";
                                    string logMessage = $"{DateTime.Now}: Error - {ex.Message}{Environment.NewLine}";
                                    File.AppendAllText(filePath, logMessage);
                                    Console.WriteLine("Ett fel loggades till filen.");
                                }
                                break;

                            case "3":
                                try
                                {
                                    // Celsius till Kelvin
                                    Console.WriteLine("Skriv in antal grader Celsius: ");
                                    double celsius3 = double.Parse(Console.ReadLine());
                                    TemperatureConverter temperatureConverter3 = new TemperatureConverter();
                                    double kelvin = temperatureConverter3.CelsiusToKelvin(celsius3);
                                    string result = $" {celsius3:F2} grader Celsius är {kelvin:F2} grader Kelvin.";

                                    // Skriv ut resultatet till konsolen
                                    Console.WriteLine(result);

                                    // Skriv ut resultatet till filen med tidsstämpel
                                    string filePath = "conversion_log.txt";
                                    string logMessage = $"{DateTime.Now}: {result}{Environment.NewLine}";
                                    File.AppendAllText(filePath, logMessage);
                                    Console.WriteLine("Resultatet har sparats till filen.");
                                }
                                catch (Exception ex)
                                {
                                    // Skriv ut felmeddelandet till konsolen
                                    Console.WriteLine(ex.Message);

                                    // Skriv ut felmeddelandet till samma fil som resultat med tidsstämpel
                                    string filePath = "conversion_log.txt";
                                    string logMessage = $"{DateTime.Now}: Error - {ex.Message}{Environment.NewLine}";
                                    File.AppendAllText(filePath, logMessage);
                                    Console.WriteLine("Ett fel loggades till filen.");
                                }
                                break;



                            case "4":
                                try
                                {
                                    // Kelvin till Celsius
                                    Console.WriteLine("Skriv in antal grader Kelvin: ");
                                    double kelvin2 = double.Parse(Console.ReadLine());
                                    TemperatureConverter temperatureConverter4 = new TemperatureConverter();
                                    double celsius4 = temperatureConverter4.KelvinToCelsius(kelvin2);
                                    string result = $" {kelvin2:F2} grader Kelvin är {celsius4:F2} grader Celsius.";

                                    // Skriv ut resultatet till konsolen
                                    Console.WriteLine(result);

                                    // Skriv ut resultatet till en fil med tidsstämpel
                                    string filePath = "conversion_log.txt";
                                    File.AppendAllText(filePath, $"{DateTime.Now}: {result}{Environment.NewLine}");
                                    Console.WriteLine("Resultatet har sparats till filen.");
                                }
                                catch (Exception ex)
                                {
                                    // Skriv ut felmeddelandet till konsolen
                                    Console.WriteLine(ex.Message);

                                    // Skriv ut felmeddelandet till filen med tidsstämpel
                                    string filePath = "conversion_log.txt";
                                    File.AppendAllText(filePath, $"{DateTime.Now}: Error - {ex.Message}{Environment.NewLine}");
                                    Console.WriteLine("Ett fel loggades till filen.");
                                }
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
