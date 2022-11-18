using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? ");
            int room = int.Parse(Console.ReadLine());
            
            Student[] vect = new Student[10];

            for(int i = 1; i <= room; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"RENT #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int chosenRoom = int.Parse(Console.ReadLine());
                vect[chosenRoom] = new Student(name, email);    
            }

            Console.WriteLine();
            Console.WriteLine("Occupied rooms:");
            for (int i = 0; i < 10; i++)
                if (vect[i] != null)
                    Console.WriteLine(i + ": " + vect[i]);
               
            Console.WriteLine();
            Console.WriteLine("Empty rooms: ");
            for (int i = 0; i < 10; i++)
                if (vect[i] == null)
                    Console.Write(i + " ");

            Console.ReadLine();
        }
    }
}