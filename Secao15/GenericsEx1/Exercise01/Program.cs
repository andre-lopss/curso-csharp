using System;
using System.IO;
using System.Collections.Generic;
using Exercise01.Entities;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<LogRecord> users = new HashSet<LogRecord>();
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        DateTime instant = DateTime.Parse(line[1]);
                        users.Add(new LogRecord(line[0], instant));
                    }
                    Console.WriteLine("Total users: " + users.Count);
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
