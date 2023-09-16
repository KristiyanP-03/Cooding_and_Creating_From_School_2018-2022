using System;
using System.Collections.Generic;

namespace Rechnik
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> words = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string meaning = Console.ReadLine();
                words.Add(word, meaning);
            }
            foreach (var word in words)
            {
                Console.WriteLine($"{words.Keys} -> {words.Values}");
            }
        }
    }
}
