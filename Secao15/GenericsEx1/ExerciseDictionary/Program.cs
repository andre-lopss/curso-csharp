using System;
using System.Collections.Generic;
using System.IO;

namespace ExerciseDictionary
{
    //Enunciado:
    //Na contagem de votos de uma eleição, são gerados vários registrosde votação contendo o nome do candidato e a quantidade de votos(formato.csv) que ele obteve em uma urna de votação.Você devefazer um programa para ler os registros de votação a partir de umarquivo, e daí gerar um relatório consolidado com os totais de cadacandidato.
    //File exemple:
    //Alex Blue,15
    //Maria Green,22
    //Bob Brown,21
    //Alex Blue,30
    //Bob Brown,15
    //Maria Green,27
    //Maria Green,22
    //Bob Brown,25
    //Alex Blue,31
    class Program
    { 
        static void Main(string[] args)
        {
            Dictionary<string, int> candidate = new Dictionary<string, int>();

            Console.Write("Enter file full path: ");
            string pathSource = Console.ReadLine();

            using (StreamReader sr = File.OpenText(pathSource))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(',');
                    string name = line[0];
                    int wisches = int.Parse(line[1]);

                    if (candidate.ContainsKey(name))
                        candidate[name] += wisches;
                    else
                        candidate[name] = wisches;
                }

                foreach (KeyValuePair<string, int> item in candidate)
                    Console.WriteLine(item.Key + ": " + item.Value);
            }
            Console.ReadLine();
        }
    }
}