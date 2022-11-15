namespace ExerciciosSecaoQuatro
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double AreaRetangulo()
        {
            return Largura * Altura;
        }

        public double PerimetroRetangulo()
        {
            return (Largura + Altura) * 2;
        }

        public double DiagonalRetangulo()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

    }
}
