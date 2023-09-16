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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        Random Num = new Random();

        private void button2_Click(object sender, EventArgs e)
        {
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
                if (maskedTextBox2.Text == maskedTextBox3.Text)
                {
                    MessageBox.Show("Успешно се регистрирахте. Ура! :D");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Грешно сте въвели повторно паролата или кода за самоличност не е верен! Опитайте пак. :)");
            }
            if (textBox5.Text != textBox2.Text)
            {
                if (maskedTextBox2.Text != maskedTextBox3.Text)
                {
                    MessageBox.Show("Грешно сте въвели повторно паролата или кода за самоличност не е верен! Опитайте пак. :)");
                }
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
