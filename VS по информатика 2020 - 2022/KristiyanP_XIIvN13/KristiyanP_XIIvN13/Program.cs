using System;

namespace KristiyanP_XIIvN13
{
    class Program
    {
        static void Main(string[] args)
        {
            //начало, променливи, цел и банка
            int goal = int.Parse(Console.ReadLine());
            int wallet = int.Parse(Console.ReadLine());
            int days = 0;
            int WastingDays =  0;
            //цикъл от действия
            while (true)
            {
             //действие
              string deistvie = Console.ReadLine();
             //спестява
             if (deistvie == "save")
             {
              days++;
              WastingDays = 0;
              int SavedMoney = int.Parse(Console.ReadLine());
              wallet += SavedMoney;   
                if (goal <= wallet)
                {
                   Console.WriteLine($"You saved the money for {days} days.");
                   break;     
                }
             }
             //харчи
             if (deistvie == "spend")
             {
              days++;
              WastingDays++;
              int SpendedMoney = int.Parse(Console.ReadLine());
              wallet -= SpendedMoney;
                    if (wallet <= 0)
                    {
                        wallet = 0;
                    }
               if (WastingDays == 5)
               {
                 Console.WriteLine("You can't save money");
                 Console.WriteLine($"{days}");
                 break;
               }     
             }
            }
        }
    }
}
