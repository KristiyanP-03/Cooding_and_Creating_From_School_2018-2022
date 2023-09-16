using System;

namespace Izklqcheniq
{
    class Program
    {
        static void Main(string[] args)
        {
        try
            {
                int number = int.Parse(Console.ReadLine());
                double result = Math.Sqrt(number);
                Console.WriteLine(result);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("");
            
            }
        }
    }
}

