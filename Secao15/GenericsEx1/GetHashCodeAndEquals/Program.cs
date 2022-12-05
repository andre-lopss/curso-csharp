using System;
using GetHashCodeAndEquals.Entities;

namespace GetHashCodeAndEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            //string a = "Maria";
            //string b = "João";
            //Console.WriteLine(a.Equals(b));
            //Console.WriteLine(a.GetHashCode());
            //Console.WriteLine(b.GetHashCode());
            Client a = new Client() { Name = "André", Email = "andre@hotmail.com" };
            Client b = new Client() { Name = "Maria", Email = "maria@hotmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());


            Console.ReadLine();
        }
    }
}
