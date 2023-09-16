using System;
using System.Collections.Generic;
using System.Text;

namespace Kapsulirane
{
    class Person
    {
        private string firstname;
        private string lastname;
        private int age;
        private decimal salary;

        static void IncreaseSalary(decimal percentage)
        {

        }

        public string FirstName
        {
            get
            {
                return firstname;
            }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("First name cannot contain fewer than 3 symbols!");
                }
                else
                {
                    firstname = value;
                }
            }
        }
        public string LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Last name cannot contain fewer than 3 symbols!");
                }
                else
                {
                    lastname = value;
                }
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (age <= 0)
                {
                    Console.WriteLine("Age cannot be zero or a negative integer!");
                }
                else
                {
                    age = value;
                }
            }
        }
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (salary <= 460)
                {
                    Console.WriteLine("Salary cannot be less than 460 leva!");
                }
                else
                {
                    salary = value;
                }
            }
        }
        
    }
}
