using System;
using System.Globalization;
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

            Console.Write("Digite a quantidade de produtos: ");
            int products = int.Parse(Console.ReadLine());

            Product[] vect = new Product[products];

            for(int i = 0; i < products; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[products] = new Product { Name = name, Price = price };
            }

            double sum = 0.00;
            for(int i = 0; i < products; i++)
            {
                sum += vect[i].Price;
            }

            Console.WriteLine("AVARAGE PRICE = " + (sum / products).ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}