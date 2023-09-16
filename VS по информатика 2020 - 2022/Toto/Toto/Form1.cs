using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Random Num = new Random();
            for (int i = 1; i <= 49; i++)
            {
                int x = Num.Next();
                x = x % 49;
                textBox1.Text = x.ToString();
            }
            for (int i = 1; i <= 49; i++)
            {
                int x = Num.Next();
                x = x % 49;
                textBox2.Text = x.ToString();
            }
            for (int i = 1; i <= 49; i++)
            {
                int x = Num.Next();
                x = x % 49;
                textBox3.Text = x.ToString();
            }
            for (int i = 1; i <= 49; i++)
            {
                int x = Num.Next();
                x = x % 49;
                textBox4.Text = x.ToString();
            }
            for (int i = 1; i <= 49; i++)
            {
                int x = Num.Next();
                x = x % 49;
                textBox5.Text = x.ToString();
            }
            for (int i = 1; i <= 49; i++)
            {
                int x = Num.Next();
                x = x % 49;
                textBox6.Text = x.ToString();
            }
        }
    }
}
