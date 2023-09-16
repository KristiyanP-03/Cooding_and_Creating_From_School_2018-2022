using System;

namespace clasove
{
    class Car //декларация на клас
    {
        //атрибути - характеристики
        //методи

        string brand; //полета
        string model;
        string fuel;
        int year;

       public Car()
        {

        }
        //конструктор

        public string Brand
        {
            get; set;
        }

        static void Main()
        {
            Car firstCar = new Car();    // new - обект от този клас

            firstCar.brand = "Audi";
            firstCar.model = "A4";
            firstCar.year = 2005;

            Car secondCar = new Car();
            secondCar.Brand = "BMW";
            secondCar.model = "M3 C30";

            Console.WriteLine("Brands is {0}, model is {1}, year is {2}", firstCar.brand, firstCar.model, firstCar.year);
        
        
        }
    }
}
