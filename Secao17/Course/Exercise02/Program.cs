using System;
using Exercise02.Entities;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employee> emp = new List<Employee>();

            using(StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double price = double.Parse(fields[2], CultureInfo.InvariantCulture);

                    emp.Add(new Employee(name, email, price));
                }
            }

            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine());
        }
    }
}
