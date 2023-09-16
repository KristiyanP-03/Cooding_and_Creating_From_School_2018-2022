using System;

namespace KPisev13_zad2_11._17._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int Num1 = 0;
            int Num2 = 0;

            for (int i = 1; i < n; i++)
            {
                int LeftNumber = int.Parse(Console.ReadLine());
                Num2 += LeftNumber;
            }
            if(Num1 == Num2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {Num2}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Num1 - Num2 }");
            }

        }
    }
}
