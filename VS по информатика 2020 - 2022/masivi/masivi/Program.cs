using System;

namespace masivi
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int[] masiv1 = { 70, 60, 50, 40, 30, 20, 10 };
            Console.WriteLine(masiv1[0]);
            Console.WriteLine(masiv1[1]);
            Console.WriteLine(masiv1[2]);
            Console.WriteLine(masiv1[3]);
            Console.WriteLine(masiv1[4]);
            Console.WriteLine(masiv1[5]);
            Console.WriteLine(masiv1[6]);

            //2
            string[] masiv2 = { "Good", "day" , "to you" };
            Console.WriteLine(masiv2[0]);
            Console.WriteLine(masiv2[1]);
            Console.WriteLine(masiv2[2]);

            //3
            string[] masiv3 = new string[7];
            masiv3 [0] = "Monday";
            masiv3[1] = "Tuesday";
            masiv3[2] = "Wednesday";
            masiv3[3] = "Thursday";
            masiv3[4] = "Friday";
            masiv3[5] = "Saturday";
            masiv3[6] = "Sunday";
            Console.WriteLine(masiv3[0]);
            Console.WriteLine(masiv3[1]);
            Console.WriteLine(masiv3[2]);
            Console.WriteLine(masiv3[3]);
            Console.WriteLine(masiv3[4]);
            Console.WriteLine(masiv3[5]);
            Console.WriteLine(masiv3[6]);

            //4
            int n = int.Parse(Console.ReadLine());
            int[] masiv4 = new int[n];
            for (int i = 0; i < n; i++)
            {
                masiv4 [i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(masiv4[i]);
            }
        }
    }
}
