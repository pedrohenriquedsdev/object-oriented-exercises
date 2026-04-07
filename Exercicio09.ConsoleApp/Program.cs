using System;

namespace Exercicio09.ConsoleApp
{
    class CalculadoraMediaHarmonica
    {
        private double nota1;
        private double nota2;
        private double nota3;

        public CalculadoraMediaHarmonica(double nota1, double nota2, double nota3)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }

        public double CalcularMediaHarmonica()
        {
            int quantidadeNotas = 3;

            double somaDosInversos = (1.0 / nota1) + (1.0 / nota2) + (1.0 / nota3);
            double mediaHarmonica = quantidadeNotas / somaDosInversos;

            return mediaHarmonica;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CÁLCULO DA MÉDIA HARMÔNICA ===\n");

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

            double mediaAritmetica = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("\n--- RESULTADO ---");
            Console.WriteLine($"Notas informadas: {nota1:F2}, {nota2:F2}, {nota3:F2}");
            Console.WriteLine($"Média Aritmética: {mediaAritmetica:F2}");
            Console.WriteLine($"Média Harmônica: {mediaHarmonica:F2}");

            Console.ReadLine();
        }
    }
}