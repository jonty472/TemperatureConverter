// See https://aka.ms/new-console-template for more information
using TemperatureConverterTool;

Console.Write("Conversions -\n1. To fahrenheit\n2. To celsius\n: ");
string ConversionType = Console.ReadLine();
int ConverstionType = Convert.ToInt16(ConversionType);

Console.Write("Enter temperature: ");
string Temperature = Console.ReadLine();
float TemperatureFloat = Convert.ToSingle(Temperature);

TemperatureConverter conversion = new TemperatureConverter(ConverstionType, TemperatureFloat);
if (conversion.ConversionType == 2)
{
    Console.WriteLine(conversion.ToCelsius(conversion.TemperatureValue));
}

