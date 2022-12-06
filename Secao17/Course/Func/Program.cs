using System;
using System.Collections.Generic;
using Func.Entities;
using System.Linq;

//Fazer um programa que, a partir de uma lista de produtos, gere uma nova lista contendo os nomes dos produtos em caixa alta.
namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //referencia por metodo
            //List<string> result = list.Select(NameUpper).ToList();

            //referencia por Func<>
            //Func<Product, string> func = NameUpper;
            //List<string> result = list.Select(func).ToList();

            //Referência por lambda
            //Func<Product, string> func = p => p.Name.ToUpper();
            //List<string> result = list.Select(func).ToList();

            //Referência por lambda inline
            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
