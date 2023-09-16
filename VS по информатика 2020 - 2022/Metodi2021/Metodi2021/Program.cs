using System;

namespace Metodi2021
{
    class Program
    {
        static void Main(string[] args)
        {
            ocenka(3.45);
            ocenka(5.45);
            ocenka(3.90);
            ocenka(2.30);
        }
        public static void ocenka(double ocenka)
        {

            if (ocenka <= 2.99 && ocenka >= 2)
            {
                Console.WriteLine("Poor");
            }
            else if (ocenka <= 3.49)
            {
                Console.WriteLine("Bad");
            }
            else if (ocenka <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (ocenka <= 5.49)
            {
                Console.WriteLine("Very Good");
            }
            else if (ocenka <= 6)
            {
                Console.WriteLine("Exellent");
            }
        }
    }
}
