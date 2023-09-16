using System;

namespace RandomChisla
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Num = new Random();
            for (int i = 1; i <= 10; i++)
            {
                int x = Num.Next();
                x = x % 11;
                Console.WriteLine(x);
            }
        }
    }
}
