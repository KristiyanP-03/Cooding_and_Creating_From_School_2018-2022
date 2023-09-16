using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace neshtoSuSspisaci
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Libraly = new List<int>();

            string title = Console.ReadLine();
            Libraly.Add(title);
            string author = Console.ReadLine();
            Libraly.Add(author);
            int publicationdate = int.Parse(Console.ReadLine());
            Libraly.Add(publicationdate);
            decimal price = Console.ReadLine();
            Libraly.Add(price);
            string publisher = Console.ReadLine();
            Libraly.Add(publisher);
            int discount = Console.ReadLine();
            Libraly.Add(discount);
        }
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int PublicationDate { get; set; }
            public double Price { get; set; }
            public string Publisher { get; set; }
            public int Discount { get; set; }
        }
    }
}
