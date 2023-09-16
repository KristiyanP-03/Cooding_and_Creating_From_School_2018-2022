using System;

namespace aciwo
{
    class charArray
    {
        char[] el;
        int Lenght;
        public charArray()
        {
            el = new char[64];
            Lenght = 0;
        }
        public charArray(int n)
        {
            el = new char[n];
            Lenght = 0;
        }
        public charArray(string s)
        {
            el = new char[s.Length + 1];
            this.Lenght = s.Length;
            for (int i = 0; i < s.Length; i++)
            {
                this.el[i] = s[i];
            }
        }
        public string ToString()
        {
            string res = new string("");
            for (int i = 0; i < this.Lenght; i++)
            {
                res = res + this.el[i];
            }
            return res;
        }
        public void Delete(int pos)
        {
            for (int i = pos; i < this.Lenght - 1; i++)
            {
                this.el[i] = this.el[i + 1];
            }
            this.Lenght--;
        }
        public void Replace(int pos, char item)
        {
            this.el[pos] = item;
        }
        public void Insert(int pos, char item)
        {
            for (int i = this.Lenght; i > pos; i--)
            {
                this.el[i] = this.el[i - 1];
            }
            this.el[pos] = item;
            this.Lenght++;
        }
        class Program
        {
            static void Main(string[] args)
            {
                string tmp = Console.ReadLine();
                charArray s = new charArray(tmp);
                Console.WriteLine("Въведохте: ");
                Console.WriteLine(s.ToString());
                s.Delete(0);
                Console.WriteLine("Изтрихте първата буква: ");
                Console.WriteLine(s.ToString());
                s.Insert(5, '@');
                Console.WriteLine("Вмъкнахте @ в началото: ");
                Console.WriteLine(s.ToString());
                s.Replace(tmp.Length - 1, '!');
                Console.WriteLine("Заменихте края с !");
                Console.WriteLine(s.ToString());
            }
        }
    }
}
