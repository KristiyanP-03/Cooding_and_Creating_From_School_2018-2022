using System;

namespace clasove_i_obecti
{
    class Student
    {
        string ime;
        int klas;
        int nomer;
        double BELocenka;
        double MATocenka;
        double AEocenka;
        double INFOocenka;
        double ITocenka;
        double FVSocenka;
        double sredenUspeh = 0;
        void Spravka()
        {
            sredenUspeh += (BELocenka + MATocenka + AEocenka + INFOocenka + ITocenka + FVSocenka)/6;
            Console.WriteLine("Sreden uspekh - {0}", sredenUspeh);
        }
        void Harakteristika()
        {

            Console.WriteLine("Za uspekh na {0}, uchenik ot {1} klas, nomer {2}",ime, klas, nomer);
            Console.WriteLine("Bŭlgarski ezik - {0}", BELocenka);
            Console.WriteLine("Matematika - {0}", MATocenka);
            Console.WriteLine("Angliĭski - {0}", AEocenka);
            Console.WriteLine("Informatika - {0}", INFOocenka);
            Console.WriteLine("FVS - {0}", FVSocenka);
            
        }
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.ime = "Mitko";
            student1.klas = 7;
            student1.nomer = 16;
            student1.BELocenka = 6.00;
            student1.MATocenka = 4.50;
            student1.AEocenka = 5.50;
            student1.INFOocenka = 5.00;
            student1.ITocenka = 5.00;
            student1.FVSocenka = 6.00;
            student1.Harakteristika();
            student1.Spravka();

            Student student2 = new Student();
            student2.ime = "Dido";
            student2.klas = 8;
            student2.nomer = 7;
            student2.BELocenka = 5.00;
            student2.MATocenka = 6.00;
            student2.AEocenka = 5.00;
            student2.INFOocenka = 6.00;
            student2.ITocenka = 5.00;
            student2.FVSocenka = 5.00;
            student2.Harakteristika();
            student2.Spravka();

            Student student3 = new Student();
            student3.ime = "Gio";
            student3.klas = 9;
            student3.nomer = 6;
            student3.BELocenka = 5.50;
            student3.MATocenka = 5.50;
            student3.AEocenka = 4.50;
            student3.INFOocenka = 4.00;
            student3.ITocenka = 5.00;
            student3.FVSocenka = 6.00;
            student3.Harakteristika();
            student3.Spravka();

        }
    }
}
