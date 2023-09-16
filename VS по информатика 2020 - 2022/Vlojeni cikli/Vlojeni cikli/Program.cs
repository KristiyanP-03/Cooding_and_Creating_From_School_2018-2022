using System;

namespace Vlojeni_cikli
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int h = 0; h <= 23; h++)
            {
                for (int min = 0; min <= 59; min++)
                {
                    for (int sec = 0; sec <= 59; sec++)
                    {
                        Console.WriteLine($"{h}:{min}:{sec}");
                    }
                }
            }
        }
    }
}
