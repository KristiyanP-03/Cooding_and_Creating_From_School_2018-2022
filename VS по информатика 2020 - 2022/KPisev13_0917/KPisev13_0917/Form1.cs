using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPisev13_0917
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int calori = 0;
            int vreme = int.Parse(textBox1.Text);
            int sc = 0;
            textBox1.Text = vreme.ToString();

            //Плуване Бягане Ходене Колоездене
            if (comboBox1.Text == "Плуване")
            {
                calori = 10;
                label7.Text = "Плуване";
                sc = calori * vreme;
                label6.Text = sc.ToString();
            }
            else if (comboBox1.Text == "Бягане")
            {
                calori = 8;
                label7.Text = "Бягане";
                sc = calori * vreme;
                label6.Text = sc.ToString();
            }
            else if (comboBox1.Text == "Ходене")
            {
                calori = 4;
                label7.Text = "Ходене";
                sc = calori * vreme;
                label6.Text = sc.ToString();
            }
            else if (comboBox1.Text == "Колоездене")
            {
                calori = 12;
                label7.Text = "Колоездене";
                sc = calori * vreme;
                label6.Text = sc.ToString();
            }

        }
    }
}
