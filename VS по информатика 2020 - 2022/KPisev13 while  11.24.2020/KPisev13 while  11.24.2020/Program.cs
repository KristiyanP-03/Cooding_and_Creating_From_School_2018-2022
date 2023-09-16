using System;

namespace KPisev13_while__11._24._2020
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                    string book1 = Console.ReadLine();
                    while (book1 == "The Great Gatsby")
                    {
                        Console.WriteLine("You found it.");
                        break;
                    }
                    Console.WriteLine("Тhis is not the book that you are looking for.");
                    string book2 = Console.ReadLine();
                    while (book2 == "The Great Gatsby")
                    {
                        Console.WriteLine("You found it.");
                        break;
                    }
                    Console.WriteLine("Тhis is not the book that you are looking for.");
                    string book3 = Console.ReadLine();
                    while (book3 == "The Great Gatsby")
                    {
                        Console.WriteLine("You found it.");
                        break;
                    }
                    Console.WriteLine("No More Books.");
                    break;
                }
            }
        }
    }
