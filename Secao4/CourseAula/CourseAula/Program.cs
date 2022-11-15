using System.Globalization;
using System;
using CourseAula;

namespace EstruturasCondicionais
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Calcular ara do trinagulo e retornar qual é maior
            //Triangulo x, y;

            //x = new Triangulo();    
            //y = new Triangulo();

            //Console.WriteLine("Entre com as medidas do Triângulo X: ");
            //x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Entre com as medidas do Triângulo Y: ");
            //y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double areaX = x.Area();

            //double areaY = y.Area();

            //Console.WriteLine("A área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            //Console.WriteLine("A área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            //if(areaX > areaY)
            //    Console.WriteLine("Maior = X");
            //else
            //    Console.WriteLine("Maior = Y");


            //Criar um produto e manipular ele pelo to string e usar metodos de remover e adicionar
            //Produto p = new Produto(); 

            //Console.WriteLine("Entre os dados do produto:");
            //Console.Write("Nome: ");
            //p.Nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade no estoque: ");
            //p.Quantidade = int.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Dados do produto: " + p);

            //Console.WriteLine();
            //Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            //int qte = int.Parse(Console.ReadLine());
            //p.AdicionarProdutos(qte);

            //Console.WriteLine();
            //Console.WriteLine("Dados do atualizados: " + p);

            //Console.WriteLine();
            //Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            //qte = int.Parse(Console.ReadLine());
            //p.RemoverProdutos(qte);

            //Console.WriteLine();
            //Console.WriteLine("Dados do atualizados: " + p);

            //Uso de membros estáticos
            Console.Write("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);
            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        
    }
}