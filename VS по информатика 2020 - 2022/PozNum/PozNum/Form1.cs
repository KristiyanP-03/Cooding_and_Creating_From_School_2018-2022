using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PozNum
{
    public partial class Form1 : Form
    {
        int x = 0;
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random Num = new Random();
            for (int i = 1; i <= 100; i++)
            {
                x = Num.Next();
                x = x % 100;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            if (a == x)
            {
                textBox2.Text = "Позна";
            }
            else if (a >= x) 
            {
                textBox2.Text = "Нагоре";
            }
            else if (a <= x)
            {
                textBox2.Text = "Надолу";
            }
            counter++;
            textBox3.Text = counter.ToString();
        }
    }
}
