﻿using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2022, 12, 05, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
            Console.WriteLine(s1.Cut(10));
            Console.ReadLine();
        }
    }
}