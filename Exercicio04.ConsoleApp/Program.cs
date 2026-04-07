namespace Exercicio04.ConsoleApp
{    
    internal class Program
    {
        static void Main(string[] args)
        {
            Percurso viagem = new Percurso();

            double consumo = viagem.ObterConsumoPorKm();

            Console.WriteLine(consumo);
            Console.ReadLine();
        }
    }
}