using System;

namespace Sortirane
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        //1
        static void BubbleSort(int[] array)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; i++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int tmp = array[j];
                        array[i] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void Selection(int[] array)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; i++)
                {
                    if (array[i] > array[j])
                    {
                        int tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        //2
        static void BubbleSort2(int[] array)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; i++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int tmp = array[j];
                        array[i] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }
            for (int i = 0; i > n; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void Selection2(int[] array)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; i++)
                {
                    if (array[i] > array[j])
                    {
                        int tmp = array[i];
                        array[i] = array[j];
                        array[j] = tmp;
                    }
                }
            }
            for (int i = 0; i > n; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
