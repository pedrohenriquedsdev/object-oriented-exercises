namespace Exercicio02.ConsoleApp
{
    internal class TemperatureConverter 
    {
        public double fahrenheit = 150;
        public double celsius;

        public double ToCelsius()
        {
            celsius = (fahrenheit - 32) / 1.8;
            return Math.Round(celsius, 2); 
        }
    }
}