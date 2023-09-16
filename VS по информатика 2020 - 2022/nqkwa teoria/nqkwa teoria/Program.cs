using System;

namespace nqkwa_teoria
{
    class Program
    {
        // [public] [static] <return_type> <method_name> ( [<param_list>] )
        static void PrintName()
        {
            Console.WriteLine("7 su");
            Console.WriteLine("www.7suvarna.com");
        }
        static void Main(string[] args)
        {
            PrintName();
            Calc();
            PrintName();
        }
        static void Calc()
        {
            int a = 6;
            int b = 6;
            Console.WriteLine(a+b);
        }
    }
}
