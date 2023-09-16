using System;
using System.IO;

namespace uchenici
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] points = new int[130];
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                points [i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; i < n; i++)
                {
                    if (points[j] > points[i])
                    {
                        int t = points[j];
                        points[j] = points[i];
                        points[i] = t;
                    }
                }
            }

            Console.WriteLine("Намери 10-те най- ");
            for (int i = 0; i < 10; i++)
            {
                StreamWriter t = new StreamWriter("Data.txt", true);
            }
        }
    }
}
