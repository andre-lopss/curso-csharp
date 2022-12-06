using System;
using System.Collections.Generic;
using System.Linq;
using Exercise01.Entities;
using System.IO;
using System.Globalization;

namespace Exercise01
{
    //Enunciado:
    //    Fazer um programa para ler um conjunto de produtos a partir de um arquivo em formato.csv(suponha que exista pelo menos um produto).
    //Em seguida mostrar o preço médio dos produtos.Depois, mostrar os nomes, em ordem decrescente, dos produtos que possuem preço inferior ao preço médio.
    
    //Input file:
    //    Tv,900.00
    //    Mouse,50.00
    //    Tablet,350.50
    //    HD Case,80.90
    //    Computer,850.00
    //    Monitor,290.00
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    list.Add(new Product(fields[0], price));
                }
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Avarege Price: " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (string p in names)
            {
                Console.WriteLine(p);
            }
            Console.ReadLine();
        }
    }
}
