namespace Exercicio05.ConsoleApp
{
    class CalculadoraEsfera
    {
        private double pi = 3.14159;
        private double raio;

        public CalculadoraEsfera(double raio)
        {
            this.raio = raio;
        }

        public double Volume()
        {
            return (4.0 / 3.0) * pi * Math.Pow(raio, 3);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o raio da esfera: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            CalculadoraEsfera calcular = new CalculadoraEsfera(raio);
            double volume = calcular.Volume();

            Console.WriteLine($"O volume da esfera é: {volume:F2}");
            Console.ReadLine();
        }
    }
}