using System;

namespace Cikli1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(i);
            }
            for (int a = 1; a <= 12; a *= 2)
            {
                Console.WriteLine(a);
            }
            int n = int.Parse(Console.ReadLine());
            for (int g = 0; g <= n; g += 5 )
            {
                Console.WriteLine(g);
            }

        }
    }
}
