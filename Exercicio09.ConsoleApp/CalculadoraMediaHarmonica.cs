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
}