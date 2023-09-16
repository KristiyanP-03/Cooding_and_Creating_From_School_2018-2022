using System;

namespace zadacha
{
    class Program
    {
        interface ITet
        {
            double Per();
            Double Area();
        }
        class RT : ITet
        {
            private double a;
            private double b;
            
            public RT (double a , double b)
            {
                this.a = a;
                this.b = b;

            }

            double ITet.Per()
            {
                return (2*a) + (2*b);
            }
            double ITet.Area()
            {
                return a * b;
            }

            interface ITet2
            {
                double Per();
                Double Area();
            }
            class KV : ITet2
            {
                private double a;
                public KV (double a)
                {
                    this.a = a;
                }
                public double Per()
                {
                    return 4 * a;

                }
                double ITet.Area()
                {
                    return a * a;
                }
            }
        }
        static void Main(string[] args)
        {
            ITet fig1 = new RT(5, 4);
            Console.WriteLine($"Nepumetop: {fig1.Per()}) Nuue: {fig1.Area()}");
            KV fig2 = new KV(5);
            Console.WriteLine($"Nepumetop {fig2.Per()}), Nuue: {fig2. Area()}");
        }
    }
}
