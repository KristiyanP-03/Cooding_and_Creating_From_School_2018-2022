using System;
    
namespace opashka
{
    class Program
    {
        static void Main(string[] args)
        {
            IntQueue numbers = new IntQueue(100);

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }

                string[] parts = line.Split();
                int command = int.Parse(parts[0]);
                int arg = 0;
                if (parts.Length == 2)
                {
                    arg = int.Parse(parts[1]);
                }
                switch(command)
                {
                    case 1:
                        numbers.Push(arg);
                        break;

                    case 2:
                        if (numbers.NotEmpty())
                        {
                            Console.WriteLine("Връщам един и същи резултат.");
                        }
                        else
                        {
                            Console.WriteLine("Връщам един и същи резултат.");
                        }
                        break;
                    case 3:
                        if (numbers.NotEmpty())
                        {
                            Console.WriteLine("Връщам един и същи резултат.");
                        }
                        else
                        {
                            Console.WriteLine("Връщам един и същи резултат.");
                        }
                        break;
                    case 4:
                        if (numbers.NotEmpty())
                        {
                            while (numbers.NotEmpty())
                            {
                                Console.WriteLine(numbers.Pop() + " ");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Връщам един и същи резултат.");
                        }
                        break;
                }
            }
        }
    }
}
