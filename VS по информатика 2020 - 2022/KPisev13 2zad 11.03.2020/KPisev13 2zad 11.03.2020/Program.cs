using System;

namespace KPisev13_2zad_11._03._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            if (s < 15)
            {
                Console.WriteLine("slow");
            }
            else if (s >= 15 && s <= 50)
            {
                Console.WriteLine("averege");
            }
            else if (s >= 50 && s <= 160)
            {
                Console.WriteLine("fast");
            }
            else if (s >= 160 && s <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else if (s > 1000)
            {
                Console.WriteLine("extremly fast");
            }
        }
    }
}
