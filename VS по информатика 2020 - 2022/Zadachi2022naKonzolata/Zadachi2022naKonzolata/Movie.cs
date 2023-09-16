using System;
using System.Collections.Generic;
using System.Text;

namespace Zadachi2022naKonzolata
{
    class Movie
    {
        //1
        string name;
        string genre;
        int year;
        double rate;
        int income;

        public string Name { set; get; }
        public string Genre { set; get; }
        public int Year { set; get; }
        public double Rate { set; get; }
        public int Income { set; get; }
        //2
        public Movie(string kname, string kgenre,int kyear, double krate, int kincome)
        {
            kname = "No name";
            kgenre = "No genre";
            kyear = 1990;
            krate = 1;
            kincome = 2000;
        }
        //3
        static void IncreaseIncome()
        { 
        
        }

        public void Print()
        {
            Console.WriteLine($"Movie: {name}, Genre: {genre}, Year: {year}, Rating: {rate}, Income {income}");
        }
        //4
    }
}
