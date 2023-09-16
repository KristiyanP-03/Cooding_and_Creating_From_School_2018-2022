using System;

namespace Metodi2021_2zad
{
    class Program
    {
        static void Main(string[] args)
        {
            chislo(2);
            chislo(-5);
            chislo(0);
        }
        public static void chislo(int chislo)
        {
            if (chislo > 0)
            {
                Console.WriteLine($"The number {chislo} is positive.");
            }
            else if (chislo < 0)
            {
                Console.WriteLine($"The number {chislo} is negative.");
            }
            else if (chislo == 0)
            {
                Console.WriteLine($"The number {chislo} is zero.");
            }
        }
    }
}
