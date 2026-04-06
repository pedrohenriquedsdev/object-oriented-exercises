namespace Exercicio01.ConsoleApp
{
    internal class Program 
    {
        static void Main(string[] args)
        {

            Calculadora calcular = new Calculadora();
            decimal volume = calcular.Volume();

            Console.WriteLine(volume);
            Console.ReadLine();

        }
    }
}
