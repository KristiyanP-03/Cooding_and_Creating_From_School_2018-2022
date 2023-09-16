using System;
using System.Collections.Generic;
using System.Text;

namespace Singeri
{
    class Singer
    {
        //1
        string name;
        int years;
        int yearsofcareer;
        int fans;
        int money;

        public string Name { set; get; }
        public int Years { set; get; }
        public int Yearsofcareer { set; get; }
        public int Fans { set; get; }
        public int Money { set; get; }
        //2
        public Singer()
        {
            name = "No name";
            years = 1;
            yearsofcareer = 1;
            fans = 1;
            money = 1;
        }
        public Singer(string kName, int kYears, int kYearsofcareer, int kFans, int kMoney)
        {
            kName = name;
            kYears = years;
            kYearsofcareer = yearsofcareer;
            kFans = fans;
            kMoney = money;
        }
        public Singer(string kName2, int kYears2, int kYearsofcareer2)
        {
            kName2 = name;
            kYears2 = years;
            kYearsofcareer2 = yearsofcareer;
        }
        //3
        public void ShowInfo()
        {
            Console.WriteLine($"Singer name: {name}, Age: {years}, Years of career: {yearsofcareer}, Fans:{fans}, Money: {money}");
        }

        public void PlayConcert()
        { 
        
        }
    }
}
