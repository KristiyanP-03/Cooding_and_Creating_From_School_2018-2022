using System;
using System.Collections.Generic;
using System.Text;

namespace Clasove_2021
{
    class Car
    {
        public string dmake = "Audi";
        public string dmodel = "A4";
        public int dyear = 2000;

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int FuelQuantity { get; set; }
        public int FuelConsumption { get; set; }

        public Car()
        {
            this.Brand = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }
        public Car(string Make, string Model, int Year, int FuelQuantity, int FuelConsumption) : base()
        {
            this.Brand = Make;
            this.Model = Model;
            this.Year = Year;
            this.FuelQuantity = FuelQuantity;
            this.FuelConsumption = FuelConsumption;
        }
        public Car(string make, string model, int year)
        {
            this.dmake = make;
            this.dmodel = model;
            this.dyear = year;
        }
    }
}
