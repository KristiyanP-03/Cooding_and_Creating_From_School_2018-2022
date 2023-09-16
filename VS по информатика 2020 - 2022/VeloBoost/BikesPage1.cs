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
    public partial class BikesPage1 : Form
    {
        public BikesPage1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BikesPage2 bikes = new BikesPage2();
            bikes.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Продавач: Мария Димитрова" + Environment.NewLine + "Тел: 089998013");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Продавач: Иван Иванов" + Environment.NewLine + "Тел: 086083128");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Купихте си велосипед!" + Environment.NewLine + "Цена: " + textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Купихте си велосипед!" + Environment.NewLine + "Цена: " + textBox1.Text);
        }
    }
}
