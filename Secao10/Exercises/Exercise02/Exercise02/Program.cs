using System;
using System.Collections.Generic;
using System.Globalization;
using Exercise02.Entities;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported(c / u / i) ?");
                char option = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(option == 'c')
                {
                    product.Add(new Product(name, price));
                 
                }else if(option == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    product.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double cus
                }
            }

        }
    }
}
