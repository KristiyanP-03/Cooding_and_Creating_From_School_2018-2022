using System;
using System.Collections;

namespace kolekciq
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();

            int[] numbers = { 5, 15, 44, 3, 18, 17 };
            string[] name = { "Кристиян", "Красимиров", "Писев" };

            a.Insert(0, name);

            a.Add("Елемент"); a.Add("Индекс"); a.Add(10); a.Add(2); a.Add(5.1); a.Add(3.5); a.Add(2.3); a.Add(11.5); a.Add(7.6); a.Add(6.4);

            a.AddRange(numbers);

            if(a.Contains(18))
            {
                a.RemoveAt(18);
            }

            double sum = (double)a[a.IndexOf(3.5)] + (double)a[a.IndexOf(5.1)] + (double)a[a.IndexOf(2.3)] + (double)a[a.IndexOf(7.6)] + (double)a[a.IndexOf(6.4)] + (double)a[a.IndexOf(11.5)];
            a.Insert(3, sum);

            Console.WriteLine(a);
        }
    }
}
