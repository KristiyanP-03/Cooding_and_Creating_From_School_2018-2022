using System;

namespace Metodi2021_3zad
{
    class Program
    {
        static void Main(string[] args)
        {
            string deistvie = Console.ReadLine();
            int chislo1 = int.Parse(Console.ReadLine());
            int chislo2 = int.Parse(Console.ReadLine());
            
            if (deistvie == "add")
            {
                add(chislo1, chislo2);
            }
            else if (deistvie == "multiply")
            {
                multiply(chislo1, chislo2);
            }
            else if (deistvie == "substract")
            {
                substract(chislo1, chislo2);
            }
            else if (deistvie == "divide")
            {
                divide(chislo1, chislo2);
            }
            
        }
        public static void add(int chislo1, int chislo2)
        {
            int resul = chislo1 + chislo2;
            Console.WriteLine(resul);
        }
        public static void multiply(int chislo1, int chislo2)
        {
            int resul = chislo1 * chislo2;
            Console.WriteLine(resul);
        }
        public static void substract(int chislo1, int chislo2)
        {
            int resul = chislo1 - chislo2;
            Console.WriteLine(resul);
        }
        public static void divide(int chislo1, int chislo2)
        {
            int resul = chislo1 / chislo2;
            Console.WriteLine(resul);
        }
    }
}
