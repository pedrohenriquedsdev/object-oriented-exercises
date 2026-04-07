namespace Exercicio03.ConsoleApp
{
    class Calculadora
    {
        private double pi = 3.14159; 
        private double raio;
        private double altura;

        public Calculadora(double raio, double altura)
        {
            this.raio = raio;
            this.altura = altura;
        }

        public double Volume()
        {
            return pi * Math.Pow(raio, 2) * altura;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o raio: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Calculadora calcular = new Calculadora(raio, altura);
            double volume = calcular.Volume();

            Console.WriteLine($"O volume do cilindro é: {volume:F2}");
            Console.ReadLine();
        }
    }
}