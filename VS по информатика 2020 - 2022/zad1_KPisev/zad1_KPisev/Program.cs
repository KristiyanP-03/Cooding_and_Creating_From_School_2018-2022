using System;

namespace zad1_KPisev
{
    class Program
    {
        static void Main(string[] args)
        {
            double rose = 5;
            double daliq = 3.80;
            double lale = 2.80;
            double narcis = 3;
            double gladiola = 2.50;
            double totalsum = 0;
            double moneyleft = 0;
            double nem = 0;

            string cvete = Console.ReadLine();
            int broi = int.Parse(Console.ReadLine());
            int bujet = int.Parse(Console.ReadLine());

            if (cvete == "Roses")
            {
                totalsum = broi * rose;
                if (totalsum <= bujet)
                {
                    if (broi >= 80)
                    {
                        totalsum = totalsum - (totalsum * 0.1);
                    }
                    moneyleft = bujet - totalsum;
                    Console.WriteLine($"Hey, you have a great garden with {broi} {cvete} and {moneyleft:F2} leva left.");
                }
                if (totalsum > bujet)
                {
                    nem = totalsum - bujet;
                    Console.WriteLine($"Not enough money, you need {nem:F2} leva more.");
                }
            }
            if (cvete == "Dahlias")
            {
                totalsum = broi * daliq;
                if (totalsum <= bujet)
                {
                    if (broi >= 90)
                    {
                        totalsum = totalsum - (totalsum * 0.15);
                    }
                    moneyleft = bujet - totalsum;
                    Console.WriteLine($"Hey, you have a great garden with {broi} {cvete} and {moneyleft:F2} leva left.");
                }
                if (totalsum > bujet)
                {
                    nem = totalsum - bujet;
                    Console.WriteLine($"Not enough money, you need {nem:F2} leva more.");
                }
            }
            if (cvete == "Tulips")
            {
                
                totalsum = broi * lale;
                if (broi >= 80)
                {
                    totalsum = totalsum - (totalsum * 0.15);
                }
                if (totalsum <= bujet)
                {
                    moneyleft = bujet - totalsum;
                    Console.WriteLine($"Hey, you have a great garden with {broi} {cvete} and {moneyleft:F2} leva left.");
                }
                if (totalsum > bujet)
                {
                    nem = totalsum - bujet;
                    Console.WriteLine($"Not enough money, you need {nem:F2} leva more.");
                }
            }
            if (cvete == "Narcissus")
            {
                totalsum = broi * narcis;
                if (broi < 120)
                {
                    totalsum = totalsum + (totalsum * 0.15);
                }
                if (totalsum <= bujet)
                {
                    moneyleft = bujet - totalsum;
                    Console.WriteLine($"Hey, you have a great garden with {broi} {cvete} and {moneyleft:F2} leva left.");
                }
                if (totalsum > bujet)
                {
                    nem = totalsum - bujet;
                    Console.WriteLine($"Not enough money, you need {nem:F2} leva more.");
                }
            }
            if (cvete == "Gladiolus")
            {
                totalsum = broi * gladiola;
                if (broi < 80)
                {
                    totalsum = totalsum + (totalsum * 0.2);
                }
                if (totalsum <= bujet)
                {
                    moneyleft = bujet - totalsum;
                    Console.WriteLine($"Hey, you have a great garden with {broi} {cvete} and {moneyleft:F2} leva left.");
                }
                if (totalsum > bujet)
                {
                    nem = totalsum - bujet;
                    Console.WriteLine($"Not enough money, you need {nem:F2} leva more.");
                }
            }
        }
    }
}
