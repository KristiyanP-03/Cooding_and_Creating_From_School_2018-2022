using System;
using System.Linq;
using System.Collections.Generic;

namespace KPisev13_zad
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            List<int> chisla = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            if (chisla.Count < 0)
            {
                chisla.RemoveAll(i => i == 0);
            }
            else
            {
                Console.WriteLine("Няма положителни числа");
            }

            chisla.Sort();
            chisla.Reverse();

            for (int i = 0; i < chisla.Count; i++)
            {
                Console.WriteLine(chisla[i]);
            }

            //2
            List<int> neshto = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();



            int[] input = { };

            //3
            List<string> imena = Console.ReadLine();

            if (text = "Stop")
            {
               brake:
            }
        }
    }
}
