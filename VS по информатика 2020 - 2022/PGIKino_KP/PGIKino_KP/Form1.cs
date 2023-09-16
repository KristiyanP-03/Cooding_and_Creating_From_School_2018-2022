using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGIKino_KP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string email = textBox1.Text;
                Regex Email = new Regex(@"([a-z]+)(@[a-z]+.[a-z]+)");
                Match match = Email.Match(email);
                if (match.Success)
                {
                    textBox1.Text = email.Replace(@"{1}", match.Groups[1].Value);
                    InfoForm Info = new InfoForm(email); //<--- Не работри!?
                    Info.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Email !!!");
                    textBox1.Clear();
                }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
