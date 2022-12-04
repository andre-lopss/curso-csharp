using System;
using System.IO;
using System.Collections.Generic;
using IComparableExercise.Entities;

namespace IComparableExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\andre\source\repos\curso-csharp\Secao14\Interface\in.txt";

            //in.txt:
                //Maria Brown,4300.00
                //Alex Green,3100.00
                //Bob Grey,3100.00
                //Anna White,3500.00
                //Alex Black,2450.00
                //Eduardo Rose,4390.00
                //Willian Red,2900.00
                //Marta Blue,6100.00
                //Alex Brown,5000.00
            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach(Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
