using System;

namespace Kapsulirane
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.FirstName = Console.ReadLine(); ;
            person.LastName = "Иванов";
            person.Age = 45;
            person.Salary = 1000;
        }
    }
}
