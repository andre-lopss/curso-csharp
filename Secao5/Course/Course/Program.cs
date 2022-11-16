using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500, 10);
            p.Nome = "Iphone";
            Console.WriteLine(p.Nome);

            Console.ReadLine();
        }       
    }
}
