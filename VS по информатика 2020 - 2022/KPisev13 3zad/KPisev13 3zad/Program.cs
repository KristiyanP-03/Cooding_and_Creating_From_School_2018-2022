using System;

namespace KPisev13_3zad
{
    class Program
    {
        static void Main(string[] args)
        {
            double Puzzle = 3.60;
            double Doll = 5;
            double Teddybear = 6.20;
            double Ball = 7.50;
            double Truck = 3;

            double priceExkurzia = double.Parse(Console.ReadLine());
            double BroiPuzzles = double.Parse(Console.ReadLine());
            double sumPuzzles = BroiPuzzles * Puzzle;
            double BroiDolls = double.Parse(Console.ReadLine());
            double sumDolls = BroiDolls * Doll;
            double BroiTeddyBears = double.Parse(Console.ReadLine());
            double sumTeddyBears = BroiTeddyBears * Teddybear;
            double BroiBalls = double.Parse(Console.ReadLine());
            double sumBalls = BroiBalls * Doll;
            double BroiTrucks = double.Parse(Console.ReadLine());
            double sumTrucks = BroiTrucks * Truck;
            double BroiSum = BroiPuzzles + BroiDolls + BroiTeddyBears + BroiBalls + BroiTrucks;
            double totalPrice = sumPuzzles + sumDolls + sumTeddyBears + sumBalls + sumTrucks;
            totalPrice = totalPrice * 0.15;

            if (BroiSum >= 50)
            {
                totalPrice -= totalPrice * 0.20;
            }
            else if (totalPrice > priceExkurzia)
            {
                double enoughMoney = totalPrice - priceExkurzia;
                Console.WriteLine("Yes! {enoughMoney:f2} lv left ");
            }
            else
            {
                double lostMoney = priceExkurzia - totalPrice;
                Console.WriteLine("Not enough money! {lostMoney:f2} lv needed.");
            }
        }
    }
}
