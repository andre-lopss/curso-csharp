using System.Globalization;
//Exercícios sobre Estrutura Repetitiva WHILE

//EXERCICIO 1: Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha incorreta informada, escrever a mensagem "Senha Invalida".Quando a senha for informada corretamente deve ser impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o valor 2002.

Console.Write("Digite a senha: ");
int senha = int.Parse(Console.ReadLine());


while (senha != 2002)
{
    Console.WriteLine("Senha Inválida");
    Console.Write("Digite a senha: ");
    senha = int.Parse(Console.ReadLine());
}

Console.WriteLine("Acesso Permitido");

//EXERCICIO 2:Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema cartesiano.Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).

Console.WriteLine("Digite as duas coordenadas: ");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

while (x != 0 && y != 0)
{
    if (x > 0 && y > 0)
        Console.WriteLine("primeiro");
    else if (x < 0 && y > 0)
        Console.WriteLine("segundo");
    else if (x < 0 && y < 0)
        Console.WriteLine("terceiro");
    else Console.WriteLine("quarto");

    Console.WriteLine("Digite as duas coordenadas: ");
    x = int.Parse(Console.ReadLine());
    y = int.Parse(Console.ReadLine());
}

//EXERCICIO 2: Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível.

Console.WriteLine("1 - Álcool | 2 - Gasolina | 3 - Diesel | 4 - Fechar programa");
Console.Write("Escolha uma das opções acima: ");
int opc = int.Parse(Console.ReadLine());
int alcool = 0;
int gasolina = 0;
int diesel = 0;

while (opc >= 1 && opc <= 4 || opc > 4)
{

    if (opc == 1)
    {
        alcool += 1;
    }
    else if (opc == 2)
    {
        gasolina += 1;
    }
    else if (opc == 3)
    {
        diesel += 1;
    }
    else if (opc == 4)
    {
        Console.WriteLine("");
        Console.WriteLine("MUITO OBRIGADO!");
        Console.WriteLine("Álcool: " + alcool);
        Console.WriteLine("Gasolina: " + gasolina);
        Console.WriteLine("Diesel: " + diesel);
        break;
    }
    else
    {
        Console.Write("");
    }
    Console.WriteLine("");
    Console.WriteLine("1 - Álcool | 2 - Gasolina | 3 - Diesel | 4 - Fechar programa");
    Console.Write("Escolha uma das opções acima: ");
    opc = int.Parse(Console.ReadLine());
}

//ESTRUTURA DE REPETIÇÃO FOR

//EXERCICIO 1: Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.

Console.Write("Digite um número: ");
int num = int.Parse(Console.ReadLine());

for (int i = 1; i <= num; i += 2)
{
    Console.WriteLine(i);
}


//EXERCICIO 2: Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida. Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo)

Console.Write("Digite a quantidades de números que deseja: ");
int intervalo = int.Parse(Console.ReadLine());
int valueIn = 0;
int valueOut = 0;


for (int i = 1; i <= intervalo; i++)
{
    int valor = int.Parse(Console.ReadLine());
    if (valor >= 10 && valor <= 20)
    {
        valueIn += 1;
    }
    else
    {
        valueOut += 1;
    }
}

Console.WriteLine("IN: " + valueIn);
Console.WriteLine("OUT: " + valueOut);


//EXERCICIO 3: Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consistede 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.
Console.WriteLine("Digite um número inteiro: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{

    string[] line = Console.ReadLine().Split(' ');
    double a = double.Parse(line[0], CultureInfo.InvariantCulture);
    double b = double.Parse(line[1], CultureInfo.InvariantCulture);
    double c = double.Parse(line[2], CultureInfo.InvariantCulture);

    double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
}

//EXERCICIO 4: Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo segundo.Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".
Console.WriteLine("Digite um número: ");
int number = int.Parse(Console.ReadLine());

for (int i = 0; i < number; i++)
{

    string[] line = Console.ReadLine().Split(' ');
    int xx = int.Parse(line[0]);
    int yy = int.Parse(line[1]);

    if (yy == 0)
    {
        Console.WriteLine("divisao impossivel");
    }
    else
    {
        double div = (double)xx / yy;
        Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
    }
}
//EXERCICIO 5: Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1. Lembrando que, por definição, fatorial de 0 é 1.

Console.WriteLine("digite o valor ao qual quer saber o fatorial: ");
int fatorial = int.Parse(Console.ReadLine());

int f = 1;

for (int i = 1; i <= fatorial; i++)
{
    f = f * i;
}
Console.WriteLine(f);

//EXERCICIO 6: Ler um número inteiro N e calcular todos os seus divisores.
Console.Write("Digite um número para saber seus divisores: ");
int divisores = int.Parse(Console.ReadLine());

for (int i = 1; i <= divisores; i++)
{
    if (divisores % i == 0)
    {
        Console.WriteLine(i);
    }
}

//EXERCICIO 7: Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas, começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor.

Console.Write("Digite um número inteiro positivo: ");
int inteiro = int.Parse(Console.ReadLine());

for (int i = 1; i <= inteiro; i++)
{
    double quadrado = Math.Pow(i, 2);
    double cubo = Math.Pow(i, 3);
    Console.WriteLine($"{i} {quadrado} {cubo}");
}