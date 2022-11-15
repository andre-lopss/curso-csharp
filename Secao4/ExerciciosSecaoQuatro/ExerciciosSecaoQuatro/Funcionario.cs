using System.Globalization;

namespace ExerciciosSecaoQuatro
{
    internal class Funcionario : Pessoa
    {
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            double _novoSalario = SalarioBruto * (porcentagem / 100);
            SalarioBruto += _novoSalario;
        }

        public override string ToString()
        {
            return Nome + ", $" + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
