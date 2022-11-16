using System.Globalization;

namespace Exercicios
{
    class Conta
    {
        public int NumeroDaConta { get; }
        public string NomeDoTitular { get;  set; }
        public double Saldo { get; private set; }

        public Conta(int numeroDaConta, string nomeDoTitular, double valorDeposito)
        {
            NumeroDaConta = numeroDaConta;
            NomeDoTitular = nomeDoTitular;
            Saldo = valorDeposito;
        }

        public double Deposito(double deposito)
        {
            return Saldo += deposito;
        }

        public double Saque(double saque)
        {
            return Saldo -= saque + 5.0;
        }

        public override string ToString()
        {
            return "Conta "
                + NumeroDaConta
                + ", Titular: "
                + NomeDoTitular
                + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
