using System;
using System.Threading;

namespace MoneyCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your profile name?");
            string profileName = Console.ReadLine();
            //variables
            int productsCount = 0;
            int totalCash = 0;
            //
            Console.WriteLine("WE ARE ON A GRIND!!!");
            Console.WriteLine("Loading ...");
            System.Threading.Thread.Sleep(3000);
            MainGame(profileName, productsCount, totalCash);
        }
        static void MainGame(string profileName, int productsCount, int totalCash)
        {
            while (true)
            {
                Console.WriteLine("┌—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————┐");
                Console.WriteLine("│" + DateTime.Now + "                                                                                                  ");
                Console.WriteLine("│" + "Curent Level: {}" + "                                                                                            ");
                Console.WriteLine("│" + "Tier: {}" + "                                                                                                    ");
                Console.WriteLine("│" + "Donators: {}" + "                                                                                                ");
                Console.WriteLine("│" + "Donator's Money: {}" + "                                                                                         ");
                Console.WriteLine("│" + $"Product: {productsCount} " + "                                                                                                 ");
                Console.WriteLine("│" + "Product's Sales: {}" + "                                                                                         ");
                Console.WriteLine(@"│                                                                                                                     │");
                Console.WriteLine(@"│                                                                                                                     │");
                Console.WriteLine(@"│                                                                                                                     │");
                Console.WriteLine(@"│                                                                                                                     │");
                Console.WriteLine(@"│                                                                                                                     │");
                Console.WriteLine(@"│                           _                                                    _                                    │");
                Console.WriteLine(@"│                        _-'_'-_                                               _|=|__________                         │");
                Console.WriteLine(@"│                     _-' _____ '-_                                           /              \                        │");
                Console.WriteLine(@"│                  _-' ___________ '-_                                       /                \                       │");
                Console.WriteLine(@"│                   |___|||||||||___|                                       /__________________\                      │");
                Console.WriteLine(@"│                   |___|||||||||___|                                        ||  || /--\ ||  ||                       │");
                Console.WriteLine(@"│                   |___|||||||o|___|                                        ||[]|| | .| ||[]||                       │");
                Console.WriteLine(@"│                   |___|||||||||___|                                      ()||__||_|__|_||__||()                     │");
                Console.WriteLine(@"│                   |___|||||||||___|                                     ( )|-|-|-|====|-|-|-|( )                    │");
                Console.WriteLine(@"│                   |___|||||||||___|                                     ^^^^^^^^^^====^^^^^^^^^^^                   │");
                Console.WriteLine("├—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————┤");
                Console.WriteLine("│    (Press F) Level up factory: {} - {}$                       (Press B) Level up Building: {} - {}$                 ");
                Console.WriteLine("│    (Press P) Sell better product: {} - {}$                    (Press A) Advertisement: {} - {}$                     ");
                Console.WriteLine("│  Manifacture products (Press Insert) than sell products (Press S), collect money and upgrade. That's all. Emjoy!    │");
                Console.WriteLine("└—————————————————————————————————————————————————————————————————————————————————————————————————————————————————————┘");
                Console.WriteLine($"  Wallet: {totalCash}$                                                                             Profile: {profileName}" );
                if (Console.ReadKey().Key == ConsoleKey.Insert)
                {
                    productsCount++;
                }
                else if (Console.ReadKey().Key == ConsoleKey.S)
                {
                    productsCount = totalCash;
                    productsCount = 0;
                }
                Console.Clear();
            }
        }
    }
}
