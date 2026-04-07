namespace Exercicio05.ConsoleApp
{
    class CalculadoraEsfera
    {
        private double pi = 3.14159;
        private double raio;

        public CalculadoraEsfera(double raio)
        {
            this.raio = raio;
        }

        public double Volume()
        {
            return (4.0 / 3.0) * pi * Math.Pow(raio, 3);
        }
    }
}