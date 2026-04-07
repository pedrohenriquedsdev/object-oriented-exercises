namespace Exercicio07.ConsoleApp
{
    class CalculadoraSalario
    {
        private double salarioBase;
        private double totalVendas;
        private double percentualComissao;

        public CalculadoraSalario(double salarioBase, double totalVendas, double percentualComissao)
        {
            this.salarioBase = salarioBase;
            this.totalVendas = totalVendas;
            this.percentualComissao = percentualComissao;
        }

        public double CalcularSalarioTotal()
        {
            double comissao = totalVendas * (percentualComissao / 100.0);
            return salarioBase + comissao;
        }

        public double CalcularComissao()
        {
            return totalVendas * (percentualComissao / 100.0);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o salário base do vendedor: R$ ");
            double salarioBase = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o total de vendas realizadas: R$ ");
            double totalVendas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o percentual de comissão (%): ");
            double percentualComissao = Convert.ToDouble(Console.ReadLine());

            CalculadoraSalario calculadora = new CalculadoraSalario(salarioBase, totalVendas, percentualComissao);

            double comissao = calculadora.CalcularComissao();
            double salarioTotal = calculadora.CalcularSalarioTotal();

            Console.WriteLine("\n--- RESULTADO ---");
            Console.WriteLine($"Salário base: R$ {salarioBase:F2}");
            Console.WriteLine($"Total de vendas: R$ {totalVendas:F2}");
            Console.WriteLine($"Percentual de comissão: {percentualComissao}%");
            Console.WriteLine($"Valor da comissão: R$ {comissao:F2}");
            Console.WriteLine($"Salário total: R$ {salarioTotal:F2}");

            Console.ReadLine();
        }
    }
}