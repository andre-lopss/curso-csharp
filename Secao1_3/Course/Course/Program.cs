using System;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int cod = 5260;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double preco3 = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}");
            Console.WriteLine("");
            Console.WriteLine($"Registro: {idade} anos de idade, código {cod} e gênero: {genero}");

            Console.WriteLine($"Medida com 8 casas decimais: {preco3:F8}");
            Console.WriteLine($"Arredondamento casas decimais: {preco3:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + preco3.ToString("F3", CultureInfo.InvariantCulture));

            //Fórmula de Delta
            double a = 1.0, b = -3.0, c = -4.0;
            double delta = (b * b) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine(x1);

            //split = recortar uma string em varios pedaços conforme a string que vc colocar entre parenteses;
            string s = Console.ReadLine();
            string[] vet = s.Split(' ');
            string A = vet[0];
            string B = vet[1];
            string C = vet[2];
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            string[] v = Console.ReadLine().Split(' ');
            string nome = v[0];
            char sexo = char.Parse(v[1]);
            int idade2 = int.Parse(v[2]);
            double altura2 = double.Parse(v[3], CultureInfo.InvariantCulture);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade2);
            Console.WriteLine(altura2.ToString("F2", CultureInfo.InvariantCulture));

            //Exercicio fim da aula 23
            Console.WriteLine("Entre com seu primeiro nome: ");
            string nome2 = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int qtdQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto");
            double prcProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade, e altura (mesma linha):");
            string[] dados = Console.ReadLine().Split(' ');
            string sobrenome3 = dados[0];
            int idade3 = int.Parse(dados[1]);
            double altura3 = double.Parse(dados[2], CultureInfo.InvariantCulture);
            Console.WriteLine("===================================");
            Console.WriteLine(nome2 + " " + sobrenome3);
            Console.WriteLine(qtdQuartos);
            Console.WriteLine(prcProd.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(sobrenome3);
            Console.WriteLine(idade3);
            Console.WriteLine(altura3.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}