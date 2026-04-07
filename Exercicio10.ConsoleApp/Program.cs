using System;

namespace Exercicio10.ConsoleApp
{
    class CalculadoraMediaPonderada
    {
        private double notaProva1;
        private double notaProva2;
        private double pesoProva1;
        private double pesoProva2;

        public CalculadoraMediaPonderada(double notaProva1, double notaProva2, double pesoProva1, double pesoProva2)
        {
            this.notaProva1 = notaProva1;
            this.notaProva2 = notaProva2;
            this.pesoProva1 = pesoProva1;
            this.pesoProva2 = pesoProva2;
        }

        public double CalcularMediaPonderada()
        {
            double somaPesos = pesoProva1 + pesoProva2;
            double somaNotasPonderadas = (notaProva1 * pesoProva1) + (notaProva2 * pesoProva2);

            return somaNotasPonderadas / somaPesos;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CÁLCULO DA MÉDIA PONDERADA ===\n");

            Console.WriteLine("DADOS DA PRIMEIRA PROVA:");
            Console.Write("Digite a nota da primeira prova: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o peso da primeira prova: ");
            double peso1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nDADOS DA SEGUNDA PROVA:");
            Console.Write("Digite a nota da segunda prova: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o peso da segunda prova: ");
            double peso2 = Convert.ToDouble(Console.ReadLine());

            if (peso1 + peso2 == 0)
            {
                Console.WriteLine("\nERRO: A soma dos pesos não pode ser zero!");
                Console.ReadLine();
                return;
            }

            CalculadoraMediaPonderada calculadora = new CalculadoraMediaPonderada(nota1, nota2, peso1, peso2);
            double mediaPonderada = calculadora.CalcularMediaPonderada();

            double mediaAritmetica = (nota1 + nota2) / 2;

            Console.WriteLine("\n--- RESULTADO ---");
            Console.WriteLine($"Prova 1: {nota1:F2} (peso {peso1})");
            Console.WriteLine($"Prova 2: {nota2:F2} (peso {peso2})");
            Console.WriteLine($"Média Aritmética: {mediaAritmetica:F2}");
            Console.WriteLine($"Média Ponderada: {mediaPonderada:F2}");

            if (mediaPonderada >= 7.0)
            {
                Console.WriteLine("\nSituação: APROVADO!");
            }
            else if (mediaPonderada >= 5.0)
            {
                Console.WriteLine("\nSituação: RECUPERAÇÃO!");
            }
            else
            {
                Console.WriteLine("\nSituação: REPROVADO!");
            }

            Console.ReadLine();
        }
    }
}