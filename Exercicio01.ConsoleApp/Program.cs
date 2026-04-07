namespace Exercicio01.ConsoleApp
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Calculadora calc = new Calculadora(); //instânciando o objeto
            double volume = calc.ObterVolume();

            Console.WriteLine("Volume da caixa retangular: " + volume);
            Console.ReadLine();

        }
    }
}

