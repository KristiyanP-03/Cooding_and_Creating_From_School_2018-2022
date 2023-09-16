using System;

namespace KPisev3103_zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            string objects = "куче, котка, гущер, бобър, яре, жираф";
            string[] recreate = objects.Split(", ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < recreate.Length; i++)
            {
                    recreate.Sort();
                    Console.WriteLine(recreate[i]);
            }
        }
    }
}