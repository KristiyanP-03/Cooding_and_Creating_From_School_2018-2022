using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SvNaElementite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Стил
        private void buttonBold_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold);
        }
        private void buttonItalic_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Italic);
        }
        private void buttonUnderline_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Underline);
        }
        //Цвят
        private void button11_Click_1(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Red;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.White;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Blue;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Yellow;
        }

    }
}
