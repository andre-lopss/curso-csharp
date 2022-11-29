﻿using System;
using System.Collections.Generic;
using System.Globalization;
using Exercise04.Entities;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company(i / c)? ");
                char option = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(option == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }else if(option == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Company(name, anualIncome, employees));
                }
                else
                {
                    Console.WriteLine("invalid option");
                }
            }
            Console.WriteLine();

            Console.WriteLine("TAXES PAID: ");
            double sum = 0.0;
            foreach (TaxPayer taxesPayer in list)
            {
                Console.WriteLine(taxesPayer.Name
                    + ": $"
                    + taxesPayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
                sum += taxesPayer.Tax();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $" + sum.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
