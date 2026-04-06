namespace Exercicio01.ConsoleApp
{
    class Calculadora
    {
        public decimal comprimento = 12m;
        public decimal largura = 10m;
        public decimal altura = 6m;

        public decimal Volume()
        {
            decimal volume = comprimento * largura * altura;
            return volume;
        }
    }

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
