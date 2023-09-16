using System;

namespace Dumerenmasiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] students = new int[n, m];
            //въвеждане
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    students[i, j] = int.Parse(Console.ReadLine());
                    Console.WriteLine(" Въведена оценка");
                }
            }
            //търсене на ученик най-висок среден успех
            int max = 0;
            int numStudent = 0;
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < m; j++)
                {
                    sum += students[i, j];
                }
                if (sum > max)
                {
                    max = sum;
                    numStudent = i + 1;

                }
            }
            //търсене на предмет с най-нисък среден успех
            int min = 1000;
            int numSubject = 0;
            for (int j = 0; j < m; j++)
            {
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum += students[i, j];
                }
                if (sum < min)
                {
                    min = sum;
                    numSubject = j + 1;

                }
            }
            Console.WriteLine($"Ученикът с най-висок успех е: {numStudent}");
            Console.WriteLine($"Предметът с най-нисък резултат е: {numSubject}");
        }
    }
}
