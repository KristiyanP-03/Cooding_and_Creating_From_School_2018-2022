using System;

namespace KPisev13_zad1_12._2._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int NiN = 0;

            for (int i = n; i > 100 && i <= 2000; i++)
            {
                Console.WriteLine(i);
                if (i%10==3)
                {
                    NiN += n;
                }
                Console.WriteLine(i);


                i++;
            }
            Console.WriteLine(n);
            Console.WriteLine(NiN);
        }
    }
}
