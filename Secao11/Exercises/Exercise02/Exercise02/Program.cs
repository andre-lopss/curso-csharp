using System;
using System.Globalization;
using Exercise02.Entities;
using Exercise02.Entities.Exceptions;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(number, holder, initialBalance, withdrawLimit);

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amountWithdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                account.Withdraw(amountWithdraw);
                Console.Write("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));

            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
            Console.ReadLine();
        }
    }
}
