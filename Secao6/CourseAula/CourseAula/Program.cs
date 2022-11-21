using System;
using System.Globalization;
using System.Collections.Generic;
namespace CourseAula
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point p;

            //p.X = 10;
            //p.Y = 20;
            //Console.WriteLine(p);

            //p = new Point();
            //Console.WriteLine(p);

            //Nullable
            //double? x = null;
            //double? y = 10.0;

            //double a = x ?? 5;
            //double b = y ?? 5;

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.Write("Digite a quantidade de alturas que deseja calcular: ");
            //int n = int.Parse(Console.ReadLine());
            //double[] vect = new double[n];  

            //for (int i = 0; i < n; i++)
            //{
            //    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //}

            //double soma = 0.0;
            //for (int i = 0; i < n; i++)
            //{
            //    soma += vect[i];
            //}

            //Console.WriteLine("Media das alturas: " + (soma / n).ToString("F2", CultureInfo.InvariantCulture));

            //Console.Write("Digite a quantidade de produtos: ");
            //int products = int.Parse(Console.ReadLine());

            //Product[] vect = new Product[products];

            //for(int i = 0; i < products; i++)
            //{
            //    string name = Console.ReadLine();
            //    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    vect[products] = new Product { Name = name, Price = price };
            //}

            //double sum = 0.00;
            //for(int i = 0; i < products; i++)
            //{
            //    sum += vect[i].Price;
            //}

            //Console.WriteLine("AVARAGE PRICE = " + (sum / products).ToString("F2", CultureInfo.InvariantCulture));
            //Modificador de acesso params
            //int s1 = Calculator.Sum( 2, 3, 9);
            //Console.WriteLine(s1);

            ////Modificador de acesso ref
            //int a = 10;
            //Calculator.Triple(ref a);
            //Console.WriteLine(a);
            //Console.WriteLine(a);

            ////Modificador de acesso out
            //int triple;
            //Calculator.Triple(a, out triple);
            //Console.WriteLine(triple);

            //Foreach
            //string[] vect = new string[] { "Maria", "André", "João" };

            //foreach(string elementos in vect)
            //{
            //    Console.WriteLine(elementos);
            //}            

            //Listas
            //List<string> list = new List<string>();
            //list.Add("Ana");
            //list.Add("João");
            //list.Add("Ana Lucia");
            //list.Insert(2, "Marco");
            //foreach(string obj in list)
            //{
            //    Console.WriteLine(obj);
            //}
            //Console.WriteLine("List Count:" + list.Count);

            //string s1 = list.Find(x => x[0] == 'A');
            //Console.WriteLine("First 'A': " + s1);

            //string s2 = list.FindLast(x => x[0] == 'A');
            //Console.WriteLine("Last 'A': " + s2);

            //int pos1 = list.FindIndex(x => x[0] == 'A');
            //Console.WriteLine("First position 'A': " + pos1);

            //pos1 = list.FindLastIndex(x => x[0] == 'A');
            //Console.WriteLine("Last position 'A': " + pos1);

            //Console.WriteLine("------------------------------------");
            //List<string> list2 = list.FindAll(x => x.Length == 5);
            //foreach(string x in list2)
            //{
            //    Console.WriteLine(x);
            //}

            //list.Remove("Ana");
            //Console.WriteLine("------------------------------------");
            //foreach (string x in list)
            //{
            //    Console.WriteLine(x);
            //}

            //list.RemoveAll(x => x[0] == 'J');
            //Console.WriteLine("------------------------------------");
            //foreach (string x in list)
            //{
            //    Console.WriteLine(x);
            //}

            //list.RemoveAt(1);
            //Console.WriteLine("------------------------------------");
            //foreach (string x in list)
            //{
            //    Console.WriteLine(x);
            //}

            //list.RemoveRange(1, 2);
            //Console.WriteLine("------------------------------------");
            //foreach (string x in list)
            //{
            //    Console.WriteLine(x);
            //}


            //Matrizes

            double[,] mat = new double[2, 3];
            Console.WriteLine(mat.Length);
            Console.WriteLine(mat.Rank);
            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine(mat.GetLength(1));

            Console.ReadLine();

        }
    }
}