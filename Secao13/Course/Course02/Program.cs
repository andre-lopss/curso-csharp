using System;
using System.IO;
namespace Course02
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\andre.lopes\source\repos\curso-csharp\file1.txt";
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
                
            }catch(IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
            Console.ReadLine();
        }
    }
}
