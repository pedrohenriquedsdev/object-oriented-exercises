namespace Exercicio05.ConsoleApp
{

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