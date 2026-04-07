namespace Exercicio08.ConsoleApp
{
    class CalculadoraLataOleo
    {
        private double pi = 3.14159;
        private double raio;
        private double altura;

        public CalculadoraLataOleo(double raio, double altura)
        {
            this.raio = raio;
            this.altura = altura;
        }

        public double CalcularVolume()
        {
            // Fórmula: V = π × r² × h
            return pi * Math.Pow(raio, 2) * altura;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CÁLCULO DO VOLUME DE UMA LATA DE ÓLEO ===\n");

            Console.Write("Digite o raio da lata (em cm): ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura da lata (em cm): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            CalculadoraLataOleo calculadora = new CalculadoraLataOleo(raio, altura);
            double volume = calculadora.CalcularVolume();

            Console.WriteLine("\n--- RESULTADO ---");
            Console.WriteLine($"Raio: {raio:F2} cm");
            Console.WriteLine($"Altura: {altura:F2} cm");
            Console.WriteLine($"Volume da lata: {volume:F2} cm³");

            // Conversão para litros (1 litro = 1000 cm³)
            double litros = volume / 1000;
            Console.WriteLine($"Capacidade: {litros:F2} litros");

            Console.ReadLine();
        }
    }
}