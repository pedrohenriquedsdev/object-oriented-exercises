namespace Exercicio03.ConsoleApp
{
    class Calculadora
    {
        public double r = 20;
        public double h = 10;

        public double ObterVolume()
        {
            double v = Math.PI * Math.Pow(r, 2) * h;
            return v;
        }
    }
}