using System;
using System.Globalization;
using System.IO;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string sourcePath = @"C:\Users\andre\source\repos\curso-csharp\Secao13";
            try
            {
                string targetFolderPath = sourcePath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    Console.Write("Entre com a quantidade de produtos que deseja adicionar: ");
                    int n = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= n; i++)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Produto #{i}:");
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Preço: ");
                        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Quantidade: ");
                        int quantidade = int.Parse(Console.ReadLine());
                        Product prod = new Product(nome, preco, quantidade);

                        sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
