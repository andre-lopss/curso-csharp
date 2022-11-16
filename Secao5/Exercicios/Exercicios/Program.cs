using System;
using System.Globalization;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá deposito inicial? (s/n): ");
            char deposito = char.Parse(Console.ReadLine());
            double valorDeposito = 0;
            if (deposito == 's')
            {
                Console.Write("Entre com o valor de deposito inicial: ");
                valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();
            }
            else if(deposito == 'n')
            {
                Console.WriteLine();
            }
            Conta c1 = new Conta(numeroConta, titular, valorDeposito);

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c1);

            Console.WriteLine();
            Console.Write("Entre um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c1);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c1);

            Console.ReadLine();
        }
    }
}