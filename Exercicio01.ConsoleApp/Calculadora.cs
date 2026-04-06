namespace Exercicio01.ConsoleApp
{
    class Calculadora
    {
        public decimal comprimento = 10m;
        public decimal largura = 10m;
        public decimal altura = 6m;

        public decimal Volume()
        {
            decimal volume = comprimento * largura * altura;
            return volume;
        }
    }
}
