using System;

namespace KPisev13_zad1_11._17._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int Num = 0;

            for (int i = 0; i < n; i += n)
            {
                int Number = int.Parse(Console.ReadLine());
                Number += Num;

            }
        }
    }
}
