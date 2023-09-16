using System;
using System.Collections.Generic;
using System.Text;


namespace Interfeisite
{

    interface ICar
    {

    }
    class Renault : ICar
    {
        public string rModel;
        public string rColor;
        public void Start()
        {
            Console.WriteLine("Éngine start");
        }
        public void Stop()
        {
            Console.WriteLine("Breaaak!");
        }

        public Renault(string model, string color)
        {
            this.rModel = model;
            this.rColor = color;
        }
     }
    class Tesla : ICar, IElectricCar
    {
        public void Start()
        {
            Console.WriteLine("Éngine start");
        }
        public void Stop()
        {
            Console.WriteLine("Breaaak!");
        }
        public string tModel;
        public string tColor;
        public int tBattery;
        public Tesla(string model, string color, int battery)
        {
            this.tModel = model;
            this.tColor = color;
            this.tBattery = battery;

        }
    }
}
