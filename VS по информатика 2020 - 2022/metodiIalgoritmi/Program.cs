using System;

namespace metodiIalgoritmi
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public double Area1(double a, double b, double c)
        {
            double p = (a + b + c) / 2.0;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p * c));
            return S;
        }
        public double Area2(double a, double b, double angle)
        {
            double S = a * b * Math.Sin(angle) / 2;
            return S;
        }
        public double Area3(double a, double h)
        {
            double S = a * h / 2;
            return S;
        }
        public double Area4(double a, double b, double c, double R)
        {
            double S = a * b * c / (4 / R);
            return S;
        }
        public double Area5(double a, double b, double c, double r)
        {
            double p = (a + b + c) / 2;
            return p * r;
        }
    }
}
