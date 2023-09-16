using System;

namespace KPisev13_zad2_12._2._2020
{
    class Program
    {
        static void Main(string[] args)
        { 
            int n = int.Parse(Console.ReadLine());
            int zaplata = 0;
            int broika = int.Parse(Console.ReadLine());
            int orchid = 10;
            int lilium = 7;
            int bonsai = 25;
            for (int i = broika; i < 1200;)
            {
                i = n * orchid + n * lilium + n * bonsai;
                Console.WriteLine(i);
                if (zaplata >= 1200)
                {
                    Console.WriteLine("Maximum salary reached.");
                    break;
                }
                i++;
            }
        }
    }
}
