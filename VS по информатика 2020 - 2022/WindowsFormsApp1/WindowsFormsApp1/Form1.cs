using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int price = 0;
            if (comboBox1.Text == "Декоративна плочка 25х40 - бежово")
            {
                price = 11;
                pictureBox1.Image = Image.FromFile("25x40_dekor_bejovo.jpg");
                textBox8.Text = price.ToString() + " лв.";
            }
            else if (comboBox1.Text == "Декоративна плочка 25х40 – светло сиво")
            {
                price = 15;
                pictureBox1.Image = Image.FromFile("25x40_dekor_svetlo_sivo.jpg");
                textBox8.Text = price.ToString() + " лв.";
            }
            else if (comboBox1.Text == "Декоративна плочка 25х40 – сиво принт")
            {
                price = 13;
                pictureBox1.Image = Image.FromFile("25x40_dekor_print_sivo.jpg");
                textBox8.Text = price.ToString() + " лв.";
            }
            else if (comboBox1.Text == "Плочка за стена 25х40 – светло бежово")
            {
                price = 10;
                pictureBox1.Image = Image.FromFile("25x40_stena_svetlo_bejovo.jpg");
                textBox8.Text = price.ToString() + " лв.";
            }
            else if (comboBox1.Text == "Плочка за стена 25х40 – тъмно бежово")
            {
                price = 14;
                pictureBox1.Image = Image.FromFile("25x40_stena_tumno_bejovo.jpg");
                textBox8.Text = price.ToString() + " лв.";
            }
            else if (comboBox1.Text == "Плочка за стена 25х40 – светло сиво")
            {
                price = 20;
                pictureBox1.Image = Image.FromFile("25x40_stena_svetlo_sivo.jpg");
                textBox8.Text = price.ToString() + " лв.";
            }
            else if (comboBox1.Text == "Плочка за под 34х34 - бежово")
            {
                price = 8;
                pictureBox1.Image = Image.FromFile("34x34_pod_bejovo.jpg");
                textBox8.Text = price.ToString() + " лв.";
            }
            else if (comboBox1.Text == "Плочка за под 34х34 - синьо")
            {
                price = 9;
                pictureBox1.Image = Image.FromFile("34x34_pod_sinio.jpg");
                textBox8.Text = price.ToString() + " лв.";
            }
            else if (comboBox1.Text == "Плочка за под 34х34 - сиво")
            {
                price = 12;
                pictureBox1.Image = Image.FromFile("34x34_pod_sivo.jpg");
                textBox8.Text = price.ToString() + " лв.";
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar))
            {
                int dotIndex = textBox2.Text.IndexOf('.');
                if (char.IsDigit(e.KeyChar))
                {
                    if (dotIndex != -1 && dotIndex < textBox2.SelectionStart && textBox2.Text.Substring(dotIndex + 1).Length >= 2)
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = e.KeyChar != '.' || dotIndex != -1 || textBox2.Text.Lenght == 0 || textBox2.SelectionStart + 2 < textBox2.Text.Length;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
            if (!char.IsControl(e.KeyChar))
            {
                int dotIndex = textBox1.Text.IndexOf('.');
                if (char.IsDigit(e.KeyChar))
                {
                    if (dotIndex != -1 && dotIndex < textBox1.SelectionStart && textBox1.Text.Substring(dotIndex + 1).Length >= 2)
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = e.KeyChar != '.' || dotIndex != -1 || textBox1.Text.Lenght == 0 || textBox1.SelectionStart + 2 < textBox1.Text.Length;
                }
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
    }
