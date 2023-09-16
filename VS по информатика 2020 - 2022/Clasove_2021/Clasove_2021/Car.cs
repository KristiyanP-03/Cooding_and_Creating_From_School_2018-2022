using System;
using System.Collections.Generic;
using System.Text;

namespace Clasove_2021
{
    class Car
    {
        private string brand = "";
        private string model = "";
        private int year = 0;

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
         
        public Car(string make, string model, int year) : base()
        {
            this.Brand = make;
            this.Model = model;
            this.Year = year;
        }
        
    }
}
