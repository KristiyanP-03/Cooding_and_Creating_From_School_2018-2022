﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox1.Text = ("0");
            textBox2.Text = ("0");
            label1.Text = ("0");
            textBox1.Text = textBox1.Text.Remove(0);
            textBox2.Text = textBox2.Text.Remove(0);
            label1.Text = label1.Text.Remove(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = ("0");
            double value1 = double.Parse(textBox1.Text);
            double value2 = double.Parse(textBox2.Text);
            double sum = double.Parse(label1.Text);

            label1.Text = Convert.ToString(value1 - value2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = ("0");
            double value1 = double.Parse(textBox1.Text);
            double value2 = double.Parse(textBox2.Text);
            double sum = double.Parse(label1.Text);

            label1.Text = Convert.ToString(value1 + value2);

        }
    }
}
