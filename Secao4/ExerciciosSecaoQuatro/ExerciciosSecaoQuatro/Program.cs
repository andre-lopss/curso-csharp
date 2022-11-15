using System.Globalization;

namespace ExerciciosSecaoQuatro
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1: Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.

            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade)
                Console.WriteLine("Pessoa mais velha: " + pessoa1.Nome);
            else
                Console.WriteLine("Pessoa mais velha: " + pessoa2.Nome);

            //Exercicio 2: Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários.

            Funcionario f1, f2;

            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (f1.SalarioBruto + f2.SalarioBruto) / 2;
            Console.WriteLine("Salário médio: " + media.ToString("F2", CultureInfo.InvariantCulture));

            //Exercicios de fixacao
            //Exercicio 1: Fazer um programa para ler os valores da largura e altura de um retângulo. Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe como mostrado no projeto ao lado.

            Retangulo ret = new Retangulo();
            Console.WriteLine("Entre a largura e a altura do retângulo: ");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + ret.AreaRetangulo().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + ret.PerimetroRetangulo().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + ret.DiagonalRetangulo().ToString("F2", CultureInfo.InvariantCulture));

            //Exercicio 2: Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto). Em seguida, mostrar os dados do funcionário(nome e salário líquido).Em seguida, aumentar o salário do funcionário com base em uma porcentagem dada(somente o salário bruto é afetado pela porcentagem) e mostrar novamente os dados do funcionário.Use a classe projetada abaixo.

            Funcionario funcionarioSalario = new Funcionario();

            Console.WriteLine("Entre com os dados: ");
            Console.Write("Nome: ");
            funcionarioSalario.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            funcionarioSalario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionarioSalario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + funcionarioSalario);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionarioSalario.AumentarSalario(porcentagem);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + funcionarioSalario);

            //Exercicio 3: Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no ano.Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam para o aluno obter o mínimo para ser aprovado(que é 60 pontos). Você deve criar uma classe Aluno para resolver este problema.
            
            Aluno aluno = new Aluno();
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Trimestre1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Trimestre2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Trimestre3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("NOTA FINAL = " + aluno.Soma().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(aluno.Media());


            //Exercicio Membros estáticos
            //Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda que a pessoa terá que pagar 6 % de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda para ser responsável pelos cálculos.

            Console.Write("Qual é a cotação do dólar? ");
            double dolarCotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double dolarQtdComprar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.ValorEmReais(dolarCotacao, dolarQtdComprar).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}