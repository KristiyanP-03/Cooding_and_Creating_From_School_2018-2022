using System;
using System.Collections.Generic;

namespace RechnikZad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!words.ContainsKey(word))
                {
                    words.Add(word, new List<string>());
                }
                else
                {
                    words[word].Add(synonym);
                }
            }
            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} -> {synonyme.Value} ");
            }


        }
    }
}
