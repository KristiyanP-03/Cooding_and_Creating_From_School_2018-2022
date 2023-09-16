using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectVeloBoost
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random Num = new Random();
            for (int i = 1; i <= 49; i++)
            {
                int x = Num.Next();
                x = x % 999999;
                textBox5.Text = x.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == textBox2.Text)
            {
                MessageBox.Show("Успешно влязохте в профила си. Добре дошли! :)");
                this.Close();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
