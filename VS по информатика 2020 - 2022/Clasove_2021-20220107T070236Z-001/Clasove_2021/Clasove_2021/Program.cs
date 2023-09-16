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
            Console.WriteLine($"Make: {car.Brand} Model: {car.Model} Year: {car.Year} FuelQuantity: {car.FuelQuantity} FuelConsumption: {car.FuelConsumption}");

            Car car2 = new Car("De Tomaso", "Pantera GT5", 1971, 2000, 100);
            Console.WriteLine($"Make: {car2.Brand} Model: {car2.Model} Year: {car2.Year} FuelQuantity: {car2.FuelQuantity} FuelConsumption: {car2.FuelConsumption}");
            
            Car car3 = new Car();
            Console.WriteLine($"Make: {car3.dmake} Model: {car3.dmodel} Year: {car3.dyear}");

        }
    }
}
