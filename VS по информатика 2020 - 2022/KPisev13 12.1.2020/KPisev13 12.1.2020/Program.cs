using System;

namespace KPisev13_12._1._2020
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int ABCsum = 0;
            for (int a = 0; a <= n; a++)
            {
                for (int b = 0; b <= n; b++)
                {
                    for (int c = 0; c <= n; c++)
                    {
                     if (n == a + b + c)
                        {
                            ABCsum++;
                      }
                    }
                }
            }
            Console.WriteLine(ABCsum);
        }

    }
}
