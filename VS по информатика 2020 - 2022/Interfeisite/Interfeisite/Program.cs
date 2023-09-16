using System;

namespace Interfeisite
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar renault = new Renault("Duster", "Gray");
            ICar tesla = new Tesla("Model 3", "Red", 2);

            Console.WriteLine(renault.ToString());
            Console.WriteLine(tesla.ToString());
        }
    }
}
