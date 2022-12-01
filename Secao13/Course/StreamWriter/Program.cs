using System;
using System.IO;

namespace Course_StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string SourcePath = @"C:\Users\andre.lopes\source\repos\curso-csharp\file1.txt";
            string targetPath = @"C:\Users\andre.lopes\source\repos\curso-csharp\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(SourcePath);

                using(StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
