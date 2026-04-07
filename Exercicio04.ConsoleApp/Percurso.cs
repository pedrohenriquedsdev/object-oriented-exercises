namespace Exercicio04.ConsoleApp
{
    class Percurso
    {
        public double kmInicial = 100;
        public double kmFinal = 180;
        public double consumo = 20;

        public double ObterConsumoPorKm()
        {
            double gastoPorKm = (kmFinal - kmInicial) / consumo;
            return gastoPorKm;
        }
    }
}