using System.Globalization;

namespace CourseExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Curso C# Completo - Exercícios propostos
            //Exercicio 1: Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa.
            Console.WriteLine("=====================================================");
            Console.WriteLine("EXERCICIO 1");

            Console.Write("Digite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("SOMA: " + (n1 + n2));

            //Exercicio 2:Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais.

            Console.WriteLine("=====================================================");
            Console.WriteLine("EXERCICIO 2");

            Console.Write("Digite a àrea: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double circleArea = pi * (Math.Pow(raio, 2));
            Console.WriteLine("A=" + circleArea.ToString("F4", CultureInfo.InvariantCulture));


            //Exercicio 3: Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

            Console.WriteLine("=====================================================");
            Console.WriteLine("EXERCICIO 3");

            Console.WriteLine("Digite os 4 valores inteiros (na mesma linha): ");
            string[] valores = Console.ReadLine().Split(' ');
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);
            int c = int.Parse(valores[2]);
            int d = int.Parse(valores[3]);
            double formaDiferenca = (a * b) - (c * d);
            Console.WriteLine("DIFERENÇA: " + formaDiferenca);

            //Exercicio 4: Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

            Console.WriteLine("=====================================================");
            Console.WriteLine("EXERCICIO 4");

            Console.Write("Entre com o código do funcionário: ");
            int cod = int.Parse(Console.ReadLine());
            Console.Write("Entre com as horas trabalhadas: ");
            double horas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o valor da hora: ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salary = (horas * valorHora);
            Console.WriteLine("NUMBER: " + cod);
            Console.WriteLine("SALARY: U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));

            //Exercício 5: Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago.
            Console.WriteLine("=====================================================");
            Console.WriteLine("EXERCICIO 5");

            Console.WriteLine("Digite o número da peça 1, o n° de peças 1, o valor un da peça 1 (na mesma linha): ");
            string[] peça1 = Console.ReadLine().Split(' ');
            int numeroP1 = int.Parse(peça1[0]);
            int numPeP1 = int.Parse(peça1[1], CultureInfo.InvariantCulture);
            double valorUnP1 = double.Parse(peça1[2], CultureInfo.InvariantCulture);
            double valorCompra1 = (numPeP1 * valorUnP1);

            Console.WriteLine("Digite o número da peça 2, o n° de peças 2, o valor un da peça 2 (na mesma linha): ");
            string[] peça2 = Console.ReadLine().Split(' ');
            int numeroP2 = int.Parse(peça2[0]);
            int numPeP2 = int.Parse(peça2[1], CultureInfo.InvariantCulture);
            double valorUnP2 = double.Parse(peça2[2], CultureInfo.InvariantCulture);
            double valorCompra2 = (numPeP2 * valorUnP2);

            Console.WriteLine("VALOR A PAGAR: R$ " + (valorCompra1 + valorCompra2).ToString("F2", CultureInfo.InvariantCulture));

            //Exercício 6:Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
            //a) a área do triângulo retângulo que tem A por base e C por altura.
            //b) a área do círculo de raio C. (pi = 3.14159)
            //c) a área do trapézio que tem A e B por bases e C por altura.
            //d) a área do quadrado que tem lado B.
            //e) a área do retângulo que tem lados A e B.

            Console.WriteLine("=====================================================");
            Console.WriteLine("EXERCICIO 6");

            Console.WriteLine("Digite três valores (na mesma linha): ");
            string[] dados = Console.ReadLine().Split(' ');
            double v1 = double.Parse(dados[0], CultureInfo.InvariantCulture);
            double v2 = double.Parse(dados[1], CultureInfo.InvariantCulture);
            double v3 = double.Parse(dados[2], CultureInfo.InvariantCulture);
          
            Console.WriteLine("TRIÂNGULO: " + ((v1 * v3) / 2).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + (pi * Math.Pow(v3, 2)).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + (((v1 + v2) * v3) / 2).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + (Math.Pow(v2, 2)).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETÂNGULO: " + (v1 * v2).ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}