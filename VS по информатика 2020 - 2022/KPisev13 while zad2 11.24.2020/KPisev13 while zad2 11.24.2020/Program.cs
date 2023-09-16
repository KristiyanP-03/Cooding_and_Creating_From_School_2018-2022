using System;

namespace KPisev13_while_zad2_11._24._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
               int savedmoney = int.Parse(Console.ReadLine());
                while ( savedmoney <= 2000 )
                {
                    Console.WriteLine("You don't have money");
                    break;
                }
                int savedmoney = int.Parse(Console.ReadLine());

            }
        }
    }
}
