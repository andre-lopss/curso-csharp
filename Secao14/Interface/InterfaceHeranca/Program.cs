using System;
using InterfaceHeranca.Model.Entities;
using InterfaceHeranca.Model.Enums;

namespace InterfaceHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
            IShape s2 = new Rectangle() { Width = 3.5, Heigth = 4.2, Color = Color.Black };

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.ReadLine();
        }
    }
}
