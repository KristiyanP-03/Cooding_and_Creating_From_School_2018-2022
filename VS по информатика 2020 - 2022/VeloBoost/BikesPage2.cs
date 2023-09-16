using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeloBoost
{
    public partial class BikesPage2 : Form
    {
        public BikesPage2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
            {
                BikesPage1 bikes = new BikesPage1();
                bikes.Show();
                this.Hide();

            }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Продавач: VeloBoost 7NG" + Environment.NewLine + "Тел: 08743617641");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Продавач: VeloBoost 7NG" + Environment.NewLine + "Тел: 08743617641");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Купихте си велосипед!" + Environment.NewLine + "Цена: " + textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Купихте си велосипед!" + Environment.NewLine + "Цена: " + textBox1.Text);
        }
    }
}
