using System;

namespace Students_KPisev13
{
    class Students
    {
        string name;
        int clas;
        int nomer;
        double ocenka;


        public Students (string name, int clas, int nomer , double ocenka)
        {
            this.name = name;
            this.clas = clas;
            this.nomer = nomer;
            this.ocenka = ocenka;
        }
        public Students()
        {
            this.name = null;
            this.clas = 0;
            this.nomer = 0;
            this.ocenka = 0;
        }
        public Students()
        {
            this.name = "";
            this.clas = 10;
            this.nomer = 13;
            int ocenka = int.Parse(Console.ReadLine());
        }
        void Messege()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Students firstStudent = new Students();

            firstStudent.name = "";
            firstStudent.clas = 10;
            firstStudent.nomer = 13;

                Console.WriteLine("{1}", firstStudent.name);
                Console.WriteLine();
                Console.WriteLine();
        }
    }
}
