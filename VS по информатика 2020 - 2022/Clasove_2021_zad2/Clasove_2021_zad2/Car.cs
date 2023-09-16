using System;
using System.Collections.Generic;
using System.Text;

namespace Clasove_2021_zad2
{
    class Car
    {
        private string brand = "";
        private string model = "";
        private int year = 0;
        private double fuelQuantity = 0;
        private double fuelConsumption = 0;

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public static void Drive(double distance)
        {

        }
    }
}
