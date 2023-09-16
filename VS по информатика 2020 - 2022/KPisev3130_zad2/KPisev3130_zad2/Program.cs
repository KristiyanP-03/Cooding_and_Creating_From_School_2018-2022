using System;

namespace KPisev3130_zad2
{
    class Program
    {
        static void Main(string[] args)
        {
          
        }
        static void Sort(int[] Array)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < Array.Length - 1; i++)
            {

                for (int j = i + 1; j < Array.Length; i++)
                {

                    if (Array[i] < Array[j])
                    {
                        int s = Array[i];
                        Array[i] = Array[j];
                        Array[j] = s;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Array[i]);
            }
        }
    }
}
