using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace RentaCar_13
{
    public partial class Form1 : Form
    {
        double price = 0;
        double TotalSum = 0;
        DateTime d1 = dateTimePicker1;
        DateTime d2 = dateTimePicker2;
        DateTime days = 0;
        int AudiA4 = 46;
        int Mazda6 = 40;
        int RenaultScenic = 35;
        int VWPolo = 38;
        public Form1()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Audi A4")
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\HP\Desktop\VS po info\RentaCar_13\RentaCar_13\bin\Debug\audi_a4");
            }
            else if (comboBox1.Text == "Mazda 6")
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\HP\Desktop\VS po info\RentaCar_13\RentaCar_13\bin\Debug\mazda_6");
            }
            else if (comboBox1.Text == "Renault Scenic")
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\HP\Desktop\VS po info\RentaCar_13\RentaCar_13\bin\Debug\polo");
            }
            else if (comboBox1.Text == "VW Polo")
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\HP\Desktop\VS po info\RentaCar_13\RentaCar_13\bin\Debug\scenic");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            price = 
            d1 = dateTimePicker1.Value;
            d2 = dateTimePicker2.Value;
            int days = 0;
            days = (d2 - d1).Days;

            if (checkBox1.Checked == true)
            {
                TotalSum = TotalSum + 50;
            }
            else if (checkBox2.Checked == true)
            {
                TotalSum = TotalSum + 40;
            }
            else if (checkBox3.Checked == true)
            {
                TotalSum = TotalSum + 70;
            }
            label10.Text = "{days}";
            label12.Text = "{TotalSum}";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox2.Text = "";
            richTextBox1.Text = "";
            textBox1.Text = "";
            pictureBox1.Image = null;
            comboBox1.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            label10.Text = "";
            label12.Text = "";
        }

    }
}