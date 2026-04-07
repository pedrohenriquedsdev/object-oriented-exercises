using System;

namespace Exercicio09.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CÁLCULO DA MÉDIA HARMÔNICA\n");

            Console.Write("Digite a primeira nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            if (nota1 == 0 || nota2 == 0 || nota3 == 0)
            {
                Console.WriteLine("\nERRO: Não é possível calcular a média harmônica com nota igual a zero!");
                Console.ReadLine();
                return;
            }

            CalculadoraMediaHarmonica calculadora = new CalculadoraMediaHarmonica(nota1, nota2, nota3);
            double mediaHarmonica = calculadora.CalcularMediaHarmonica();

            Console.WriteLine("\nRESULTADO");
            Console.WriteLine($"Notas informadas: {nota1:F2}, {nota2:F2}, {nota3:F2}");
            Console.WriteLine($"Média Harmônica: {mediaHarmonica:F2}");

            Console.ReadLine();
        }
    }
}