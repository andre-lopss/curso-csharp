using System;
using System.Collections.Generic;
using Exercise02.Entities;

namespace Exercise02
{
    //Enunciado:
    //    Em um portal de cursos online, cada usuário possui um código único, representado porum número inteiro.
    //Cada instrutor do portal pode ter vários cursos, sendo que um mesmo aluno pode sematricular em quantos cursos quiser.Assim, o número total de alunos de um instrutor nãoé simplesmente a soma dos alunos de todos os cursos que ele possui, pois pode haveralunos repetidos em mais de um curso.
    //O instrutor Alex possui três cursos A, B e C, e deseja saber seu número total de alunos.
    //Seu programa deve ler os alunos dos cursos A, B e C do instrutor Alex, depois mostrar aquantidade total e alunos dele, conforme exemplo.
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> students = new HashSet<Student>();
            string[] courses = { "A", "B", "C" };

            for (int i = 0; i < courses.Length; i++)
            {
                Console.Write($"How many students for course {courses[i]}? ");
                int a = int.Parse(Console.ReadLine());
                for (int j = 0; j < a; j++)
                {
                    int studentCod = int.Parse(Console.ReadLine());
                    students.Add(new Student(studentCod));
                }

            }
            Console.WriteLine("Total students: " + students.Count);
            Console.ReadLine();
        }
    }
}
