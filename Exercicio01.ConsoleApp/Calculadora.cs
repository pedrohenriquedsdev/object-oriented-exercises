namespace Exercicio01.ConsoleApp
{
    class Calculadora
    {
        public double comprimento = 2;
        public double largura = 10;
        public double altura = 12;

        public double ObterVolume()
        {
            double volume = comprimento * largura * altura;
            return volume;
        }

    }
}

