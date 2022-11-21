using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? ");
            int room = int.Parse(Console.ReadLine());

            Student[] vect = new Student[10];

            for (int i = 1; i <= room; i++)
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

            //List Exercises
            Console.Write("How many employees will be registered? :");
            int employees = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= employees; i++)
            {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.WriteLine("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(xe => xe.Id == searchId);

            if (emp != null)
            {
                Console.WriteLine("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee y in list)
            {
                Console.WriteLine(y);
            }

            //Matriz Exercises

            Console.WriteLine("Digite um numero inteiro: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                string[] numbersLine = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(numbersLine[j]);
                }
            }

            Console.Write("Main Diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }

            int neg = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                        neg++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Negative numbers: " + neg);
            Console.WriteLine();

            //Exercises 2
            Console.WriteLine("Digite o numero de linhas da matriz: ");
            int linhas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de colunas da matriz: ");
            int colunas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linhas, colunas];

            Console.WriteLine();
            for(int i = 0; i < linhas; i++)
            {
                string[] lendoLinha = Console.ReadLine().Split(' ');
                for(int j = 0; j < colunas; j++)
                {
                    matriz[i, j] = int.Parse(lendoLinha[j]);
                }
            }

            Console.WriteLine();
            Console.Write("Digite um número que está dentro da matriz: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + matriz[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }
                        if (j < colunas - 1)
                        {
                            Console.WriteLine("Right: " + matriz[i, j + 1]);
                        }
                        if (i < linhas - 1)
                        {
                            Console.WriteLine("Down: " + matriz[i + 1, j]);
                        }
                    }
                }
            }
            
            Console.ReadLine();

        }
    }
}