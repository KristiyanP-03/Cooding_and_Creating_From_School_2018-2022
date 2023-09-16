using System;

namespace Singeri
{
    class Program
    {
        static void Main(string[] args)
        {
            Singer Singer1 = new Singer();
            Singer1.ShowInfo();

            Singer Singer2 = new Singer(Console.ReadLine());
            Singer2.ShowInfo();

            Singer Singer3 = new Singer("", 50, 20);
            Singer3.ShowInfo();

            Singer Singer4 = new Singer("", 50, 20, 10000000, 2000000);
            Singer4.ShowInfo();
        }
    }
}
