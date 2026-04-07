namespace Exercicio02.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureConverter converter = new TemperatureConverter();
            
            double tempCelsius = converter.ToCelsius();

            Console.WriteLine($"A temperatura em Celsius é: {tempCelsius}°C");
            Console.ReadLine();
        }
    }
}