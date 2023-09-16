using System;

namespace KPisev13_1zad_11._03._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a < 200)
            {
                Console.WriteLine("Less than 200");
            }
            if (a >= 200 && a <= 400)
            {
                Console.WriteLine("Between 200 and 400");
            }
            if (a > 400)
            {
                Console.WriteLine("Greater than 400");
            }
        }
    }
}
