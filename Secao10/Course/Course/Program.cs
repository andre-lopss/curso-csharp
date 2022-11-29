﻿using System;
using System.Globalization;
using Course.Entities;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;
            foreach (Account account in list)
            {
                sum += account.Balance;
            }

            Console.WriteLine("Total Balance: "+sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Account account in list)
            {
                account.Withdraw(10);
            }

            foreach (Account account in list)
            {
                Console.WriteLine("Update balance for account " 
                    +account.Number
                    + ": "
                    + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }



            Console.ReadLine();
        }
    }
}