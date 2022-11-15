using System.Net;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Globalization;
using System;

namespace EstruturasCondicionais
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1: Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
            Console.WriteLine("EXERCICIO 1: O número é positivo ou negativo?");
            Console.Write("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num >= 0)
            {
                Console.WriteLine("POSITIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }

            //Exercicio 2: Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
            Console.WriteLine("===============================================");
            Console.WriteLine("EXERCICIO 2: O número é par ou ímpar?");
            Console.Write("Digite um número: ");

            int valor = int.Parse(Console.ReadLine());

            if (valor % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("ÍMPAR");
            }

            //Exercicio 3: Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em ordem crescente ou decrescente
            Console.WriteLine("===============================================");
            Console.WriteLine("EXERCICIO 3: São múltiplos?");
            Console.Write("Digite dois valores (na mesma linha): ");
            string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }


            //Exercicio 4: Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
            Console.WriteLine("===============================================");
            Console.WriteLine("EXERCICIO 4: Quantas horas foram?");
            Console.Write("Digite a hora que o jogo começou e a hora que o jogo terminou (na mesma linha): ");
            string[] horas = Console.ReadLine().Split(' ');
            int horaC = int.Parse(horas[0]);
            int horaT = int.Parse(horas[1]);
            int dia = 24;

            if (horaC > horaT)
            {
                Console.WriteLine("O JOGO DUROU " + ((dia - horaC) + horaT) + " HORAS");
            }
            else if (horaC < horaT)
            {
                Console.WriteLine("O JOGO DUROU " + (horaT - horaC) + " HORAS");
            }
            else
            {
                Console.WriteLine("O JOGO DUROU " + dia + " HORAS");
            }

            //Exercicio 5: Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem(x = y = 0).
            //Se o ponto estiver na origem, escreva a mensagem “Origem”.
            //Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação. 
            Console.WriteLine("===============================================");
            Console.WriteLine("EXERCICIO 4: EIXOS");
            Console.Write("Digite as duas coordenadas (na mesma linha): ");
            string[] eixo = Console.ReadLine().Split(' ');
            double x = double.Parse(eixo[0], CultureInfo.InvariantCulture);
            double y = double.Parse(eixo[1], CultureInfo.InvariantCulture);

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else
            {
                Console.WriteLine("Origem");
            }

            //Exercicio 6: calcular imposto:  se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido(abaixo), a taxa é de 8 % sobre R$ 1000.00 + 18 % sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com duas casas decimais.
            Console.WriteLine("===============================================");
            Console.WriteLine("EXERCICIO 6: IMPOSTO");
            Console.Write("Digite o valor do seu salário: ");
            
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto = 0;
            if(salario <= 2000.00)
            {
                imposto = 0.0;
            }else if (salario <= 3000.00)
            {
                imposto = (salario - 2000.00) * 0.08;
            }
            else if (salario <= 4500.00)
            {
                imposto = (salario - 3000.00) * 0.18 + 1000.0 * 0.08;
            }
            else if (salario > 4500.00)
            {
                imposto = (salario - 4500.00) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                Console.WriteLine("Salário está negativado");
            }
            Console.WriteLine("Imposto a pagar: R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}