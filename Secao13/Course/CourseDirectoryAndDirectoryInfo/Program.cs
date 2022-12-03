using System;
using System.IO;
using System.Collections.Generic;

namespace CourseDirectoryAndDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\andre\source\repos\curso-csharp\Secao13";
         
            try
            {
                IEnumerable<string> folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("Folders:");
                foreach(string s in folder)
                {
                    Console.WriteLine(s);
                }

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("Files:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + "\\newFolder");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
