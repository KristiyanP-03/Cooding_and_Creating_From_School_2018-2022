using System;

namespace Clasove_2021_zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Brand = "De tomaso pantera";
            car.Model = "GT5";
            car.Year = 1987;
            Console.WriteLine($"&quot;Make: {this.Make} Model: {this.Model} Year: {this.Year} Fuel:{this.FuelQuantity:F2}L & quot");
        }
        
    }
}
