namespace Exercicio02.ConsoleApp
{
    internal class TemperatureConverter 
    {
        public decimal fahrenheit = 150;
        public decimal celsius;

        public decimal ToCelsius()
        {
            celsius = (fahrenheit - 32m) / 1.8m;
            return Math.Round(celsius, 2); 
        }
    }
}