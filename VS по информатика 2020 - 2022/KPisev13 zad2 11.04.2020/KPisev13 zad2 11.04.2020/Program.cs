using System;

namespace KPisev13_zad2_11._04._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());

            int CMilk = int.Parse(Console.ReadLine());
            int CApple = int.Parse(Console.ReadLine());
            int CSugar = int.Parse(Console.ReadLine());
            int COrange = int.Parse(Console.ReadLine());
            int CRice = int.Parse(Console.ReadLine());
            int CTomato = int.Parse(Console.ReadLine());
            int CSalami = int.Parse(Console.ReadLine()); 
            
            if ( day >= 1 && day <= 5)
            {
                double milk = 2.50;
                double apple = 1.20;
                double sugar = 0.85;
                double orange = 1.45;
                double rice = 2.70;
                double tomato = 1.50;
                double salami = 3.85;
                double FinalPrice2 = (CMilk * milk + CApple * apple + CSugar * sugar + COrange * orange + CRice * rice + CTomato * tomato + CSalami * salami);
            }
            if (day >=6 && day <= 7)
            {
                double milk2 = 2.70;
                double apple2 = 1.25;
                double sugar2 = 0.90;
                double orange2 = 1.60;
                double rice2 = 3.00;
                double tomato2 = 1.80;
                double salami2 = 4.20;
                double FinalPrice2 = (CMilk * milk2 + CApple * apple2 + CSugar * sugar2 + COrange * orange2 + CRice * rice2 + CTomato * tomato2 + CSalami * salami2);
            }

        }
    }
}