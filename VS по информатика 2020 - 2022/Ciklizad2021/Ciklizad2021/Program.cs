using System;

namespace Ciklizad2021
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }
                double destinationP = double.Parse(Console.ReadLine());
                double spesteniM = 0;
                while (spesteniM < destinationP)
                {
                    double spestqvane = double.Parse(Console.ReadLine());
                    spesteniM += spestqvane;
                    if (spesteniM >= destinationP)
                    {
                        Console.WriteLine($"Going to: {destination}");
                        break;
                    }
                }
            }
        }
    }
}
