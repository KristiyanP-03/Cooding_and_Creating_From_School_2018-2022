using System;
using System.Text.RegularExpressions;

namespace LegulqrniIzrazi
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"([A-Z][a-z]+) ([A-Z][a-z]+)";

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            Console.WriteLine("{0} {1}" , match.Groups[1], match.Groups[2]);
        }
    }
}
