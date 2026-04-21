namespace Exercicio01.ConsoleApp
{
    class CaixaRetangular
    {
        public double Altura { get; set; }
        public double Largura { get; set; }
        public double Comprimento { get; set; }

        public double ObterVolume()
        {
            return Altura * Largura * Comprimento;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var caixa = new CaixaRetangular
            {
                Altura = 20,
                Largura = 20,
                Comprimento = 20
            };  

            Console.WriteLine("O volume da caixa é: {0}", caixa.ObterVolume());
        }
    }
}

