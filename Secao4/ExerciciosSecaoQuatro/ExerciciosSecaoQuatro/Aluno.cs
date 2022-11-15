using System.Globalization;

namespace ExerciciosSecaoQuatro
{
    internal class Aluno : Pessoa
    {
        public double Trimestre1;
        public double Trimestre2;
        public double Trimestre3;

        public double Soma()
        {
            return Trimestre1 + Trimestre2 + Trimestre3;
        }
        public string Media()
        {
            if(Soma() >= 60.00)
            {
                return "APROVADO";
            }
            else
            {
                return "REPROVADO"
                    + " | FALTARAM "
                    + ((60 - Soma()).ToString("F2",CultureInfo.InvariantCulture))
                    + " PONTOS.";
            }
        }
    }

}
