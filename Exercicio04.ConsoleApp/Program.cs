namespace Exercicio04.ConsoleApp
{
    class CalculadoraCombustivel
    {
        public double kmInicial;
        public double kmFinal;
        public double combustivelGasto;

        public double CalcularConsumoPorKm()
        {
            double distanciaPercorrida = kmFinal - kmInicial;
            double consumoPorKm = combustivelGasto / distanciaPercorrida;
            return consumoPorKm;
        }

        public double CalcularKmPorLitro()
        {
            double distanciaPercorrida = kmFinal - kmInicial;
            double kmPorLitro = distanciaPercorrida / combustivelGasto;
            return kmPorLitro;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CalculadoraCombustivel calculadora = new CalculadoraCombustivel();

            Console.WriteLine("=== CALCULADORA DE CONSUMO DE COMBUSTÍVEL ===\n");

            Console.Write("Digite a kilometragem INICIAL (km): ");
            calculadora.kmInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a kilometragem FINAL (km): ");
            calculadora.kmFinal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o consumo total de combustível (litros): ");
            calculadora.combustivelGasto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n=== RESULTADOS ===\n");

            if (calculadora.kmFinal <= calculadora.kmInicial)
            {
                Console.WriteLine("ERRO: A kilometragem final deve ser maior que a inicial!");
            }
            else if (calculadora.combustivelGasto <= 0)
            {
                Console.WriteLine("ERRO: O consumo de combustível deve ser maior que zero!");
            }
            else
            {
                double distancia = calculadora.kmFinal - calculadora.kmInicial;
                double consumoPorKm = calculadora.CalcularConsumoPorKm();
                double kmPorLitro = calculadora.CalcularKmPorLitro();

                Console.WriteLine($"Distância percorrida: {distancia:F2} km");
                Console.WriteLine($"Combustível gasto: {calculadora.combustivelGasto:F2} litros");
                Console.WriteLine($"\nConsumo por km: {consumoPorKm:F4} litros/km");
                Console.WriteLine($"Autonomia: {kmPorLitro:F2} km/litro");
            }

            Console.WriteLine("\nPressione ENTER para sair...");
            Console.ReadLine();
        }
    }
}