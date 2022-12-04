using System;
using System.IO;
using System.Collections.Generic;

namespace IComparableExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\andre\source\repos\curso-csharp\Secao14\Interface\in.txt";

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    List<string> list = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }
                    list.Sort();
                    foreach(string str in list)
                    {
                        Console.WriteLine(str);
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
