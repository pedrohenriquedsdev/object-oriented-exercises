namespace Exercicio06.ConsoleApp
{
    class ConversorTemperatura
    {
        private double celsius;

        public ConversorTemperatura(double celsius)
        {
            this.celsius = celsius;
        }

        public double ParaFahrenheit()
        {
            return (celsius * 9.0 / 5.0) + 32;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a temperatura em Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            ConversorTemperatura conversor = new ConversorTemperatura(celsius);
            double fahrenheit = conversor.ParaFahrenheit();

            Console.WriteLine($"{celsius}°C equivale a {fahrenheit:F2}°F");
            Console.ReadLine();
        }
    }
}