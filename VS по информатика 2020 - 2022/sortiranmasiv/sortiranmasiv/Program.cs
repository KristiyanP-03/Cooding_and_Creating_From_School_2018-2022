using System;

namespace sortiranmasiv
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        //1
        static int Search(int[] array, int x)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == x)
                {
                    return i;
                }
            }
            return x;
        }
        //2
        static int BinarySearch(int x)
        {
            int left = 0;
            int right = Array.Lenght - 1;
            while (left<=right)
            {
                int middle = (left + right) / 2;
                if (Array[middle] == x)
                {
                    return Array[middle];
                }
                if (x < Array[middle])
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            return -1;
        }
    }
}
