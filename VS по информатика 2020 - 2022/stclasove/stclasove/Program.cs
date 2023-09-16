using System;

namespace stclasove
{
    static class krugIkulbo
    {
        static double p = 3.1416;
        static public double r;
        static public double P;
        static public double s;
        static public double S;
        static public double V;

        static public void krug()
        {
            p = 2 * p * r;
            s = p * r * r;
        }
        static public void kulbo()
        {
            S = 4 * p * r * r;
            V = 4 * p * r * r * r / 3;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Периметъра на кръга е: " + p);
            Console.WriteLine("Лицето на кръга е: " + s);
            Console.WriteLine("Повърхнината на кълбото е: " + S);
            Console.WriteLine("Повърхнината на кълбото е: " + V);
        }
    }
}
