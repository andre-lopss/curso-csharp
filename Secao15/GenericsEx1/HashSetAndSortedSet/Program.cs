using System;
using System.Collections.Generic;

namespace HashSetAndSortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //HashSet<string> set = new HashSet<string>();

            //set.Add("TV");
            //set.Add("Notebook");
            //set.Add("Tablet");

            //Console.WriteLine(set.Contains("Notebook"));

            //foreach(string obj in set)
            //{
            //    Console.WriteLine(obj);
            //}

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            //union
            //Os elementos não contidos em um vão ser adicionados ao outro sem repetições.
            //SortedSet vai colocar eles ordenados
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);

            //intersection
            //Os elementos que existem nos dois conjuntos
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            //difference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);


            Console.ReadLine();
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");          
            }
            Console.WriteLine();
        }
    }
}
