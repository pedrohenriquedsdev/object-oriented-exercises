namespace Exercicio03.ConsoleApp
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            double v = calc.ObterVolume();
            Console.WriteLine(v);
            Console.ReadLine();
        }
    }
}