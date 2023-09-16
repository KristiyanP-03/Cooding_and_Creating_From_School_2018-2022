using System;

namespace KPisev13_zad1_11._10._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a * b * c > 60)
            {
                Console.WriteLine((a * b * c) * 3);
            }
            else if (a*b*c <= 60)
            {
                Console.WriteLine((a*b*c)/5);
            }
        }
    }
}
