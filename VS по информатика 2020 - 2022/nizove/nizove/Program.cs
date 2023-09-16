using System;

namespace nizove
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //string sth = Console.ReadLine();
            //string niz = "";
            //for (int i = sth.Length - 1; i >= 0; i--)
            //{
            //    niz = niz + sth[i];
            //}
            //if (niz == sth)
            //{
            //    Console.WriteLine("Това е плаиндром");
            //}
            //else
            //{
            //    Console.WriteLine("Това не е плаиндром");
            //}
            //2
            //string[] sth2 = console.readline().split(" ");
            //for (int i = sth2.length - 1; i >= 0; i--)
            //{
            //    console.writeline(sth2[i]);
            //}
            //3
            int bus = int.Parse(Console.ReadLine());
            int[] p = new int[bus];
            for (int i = 0; i < bus; i++)
            {
                p[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
