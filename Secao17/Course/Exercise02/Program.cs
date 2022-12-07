using System;
using Exercise02.Entities;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace Exercise02
{
    //Fazer um programa para ler os dados(nome, email e salário) de funcionários a partir de um arquivo em formato.csv. Em seguida mostrar, em ordem alfabética, o email dos funcionários cujo salário seja superior a um dado valor fornecido pelo usuário. Mostrar também a soma dos salários dos funcionários cujo nome começa com a letra 'M'.

    //Input file:
    //Maria,maria @gmail.com,3200.00
    //Alex, alex @gmail.com,1900.00
    //Marco, marco @gmail.com,1700.00
    //Bob, bob @gmail.com,3500.00
    //Anna, anna @gmail.com,2800.00
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            //string path = @"C:\Users\andre\source\repos\curso-csharp\Secao17\Course\Exercise.02\in.txt";

            List<Employee> emp = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
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
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Email of people whose salary is more than {salary.ToString("F2", CultureInfo.InvariantCulture)}");

            IEnumerable<string> emails = emp.Where(p => p.Salary > salary).OrderBy(p => p.Email).Select(p => p.Email);

            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }

            double m = emp.Where(p => p.Name[0] == 'M').Select(p => p.Salary).Sum();

            Console.WriteLine($"Sum of salary of people whose name starts with 'M': {m.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadLine();
        }
    }
}
