using System;

namespace KPisev13_zad2_11._10._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            double Money = double.Parse(Console.ReadLine());
            string Place = (Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            if (Place == "Velingrad")
            {
                double Room = 22.50;
                double Studio = 32.00;
                double Apartment = 52.00;
                double VipApartment = 75.00;

                if (days == 1)
                {
                    double Price = Room + Studio + Apartment;
                }
                else if (days == 2)
                {
                    double Price = 2 * (Room + Studio + Apartment);
                }
                else if (days == 3)
                {
                    double Price = 3 * (Room + Studio + Apartment);
                }
                double FinalPrice = Money - Price;
                Console.WriteLine("She will rest for {days} days in {Place} for {FinalPrice} lv.");
            }
            else if (Place == "Devin")
            {
                double Room = 22.00;
                double Studio = 30.00;
                double Apartment = 45.00;
                double VipApartment = 67.00;

                if (days == 1)
                {
                    double Price = Room + Studio + Apartment;
                }
                else if (days == 2)
                {
                    double Price = 2 * (Room + Studio + Apartment);
                }
                else if (days == 3)
                {
                    double Price = 3 * (Room + Studio + Apartment);
                }
                double FinalPrice = Money - Price;
                Console.WriteLine("She will rest for {days} days in {Place} for {FinalPrice} lv.");
            }
            else if (Place == "Razlog")
            {
                double Room = 20.00;
                double Studio = 28.50;
                double Apartment = 37.50;
                double VipApartment = 56.50;

                if (days == 1)
                {
                    double Price = Room + Studio + Apartment;
                }
                else if (days == 2)
                {
                    double Price = 2 * (Room + Studio + Apartment);
                }
                else if (days == 3)
                {
                    double Price = 3 * (Room + Studio + Apartment);
                }
                double FinalPrice = Money - Price;
                Console.WriteLine("She will rest for {days} days in {Place} for {FinalPrice} lv.");
            }
            Console.WriteLine("She will rest for {days} days in {Place} for {FinalPrice} lv.");
        }
    }
}
