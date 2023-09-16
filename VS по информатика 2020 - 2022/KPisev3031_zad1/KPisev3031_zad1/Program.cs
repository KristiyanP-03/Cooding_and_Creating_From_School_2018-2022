using System;

namespace KPisev3031_zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] m = new int[n];
            for (int i = 0; i < m.Length; i += 5)
            {
                Console.WriteLine(m[i]);
            }
        }
    }
}
