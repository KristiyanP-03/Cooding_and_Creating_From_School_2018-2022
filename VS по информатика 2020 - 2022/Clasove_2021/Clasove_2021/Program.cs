using System;

namespace Clasove_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class1 neshto = new Class1();
            //neshto.Name = "";
            //neshto.Age = "";
            //Console.WriteLine($"{neshto.Name} is");

            Car car = new Car();
            car.Brand = "De tomaso pantera";
            car.Model = "GT5";
            car.Year = 1987;
            Console.WriteLine($"Make: {car.Brand} Model: {car.Model} Year: {car.Year}");

            Car car2 = new Car();
            car2.Brand = ;
            car2.Model = "GT5";
            car2.Year = 1987;
            car2.FuelQuantity = 0;
            car2.FuelConsumption = 0;


            Car car3 = new Car();
            car3.Brand = ;
            car3.Model = ;
            car3.Year = ;

        }
    }
}
