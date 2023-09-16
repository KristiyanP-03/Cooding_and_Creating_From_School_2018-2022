using Microsoft.VisualBasic;
using System;
using System.Threading.Channels;

namespace KPisev13_zad1_11._04._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int workday = int.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());
            switch(workday)
            {
                case 1:
                    Console.WriteLine("Monday");
                    if (time >= 9 && time <= 18)
                    {
                        Console.WriteLine("Open");
                    }
                    if(time < 9)
                    {
                        Console.WriteLine("Close"); 
                    }
                    if (time > 18)
                    {
                        Console.WriteLine("Close");
                    }
                    break;

                case 2:
                    Console.WriteLine("Thuesday");
                    if (time >= 9 && time <= 18)
                    {
                        Console.WriteLine("Open");
                    }
                    if (time < 9)
                    {
                        Console.WriteLine("Close");
                    }
                    if (time > 18)
                    {
                        Console.WriteLine("Close");
                    }
                    break;

                case 3:
                    Console.WriteLine("Thirsday");
                    if (time >= 9 && time <= 18)
                    {
                        Console.WriteLine("Open");
                    }
                    if (time < 9)
                    {
                        Console.WriteLine("Close");
                    }
                    if (time > 18)
                    {
                        Console.WriteLine("Close");
                    }
                    break;

                case 4:
                    Console.WriteLine("Wednesday");
                    if (time >= 9 && time <= 18)
                    {
                        Console.WriteLine("Open");
                    }
                    if (time < 9)
                    {
                        Console.WriteLine("Close");
                    }
                    if (time > 18)
                    {
                        Console.WriteLine("Close");
                    }
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    if (time >= 9 && time <= 18)
                    {
                        Console.WriteLine("Open");
                    }
                    if (time < 9)
                    {
                        Console.WriteLine("Close");
                    }
                    if (time > 18)
                    {
                        Console.WriteLine("Close");
                    }
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    if (time >= 9 && time <= 18)
                    {
                        Console.WriteLine("Open");
                    }
                    if (time < 9)
                    {
                        Console.WriteLine("Close");
                    }
                    if (time > 18)
                    {
                        Console.WriteLine("Close");
                    }
                    break;

                case 7:
                    Console.WriteLine("Sunday");
                    Console.WriteLine("close");
                    break;
            }
        }
    }
}
