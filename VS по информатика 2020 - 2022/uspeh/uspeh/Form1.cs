using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uspeh
{
    public partial class Form1 : Form
    {
        ComboBox[] marks = new ComboBox[15];
        Label[] subjects = new Label[15];

        string[] names = {"БЕЛ", "Първи ЧЕ", "Втори ЧЕ", "Математика", "Информатика", "Инф. технологии",
        "История", "География", "Философия", "Биология", "Физика", "Химия", "Музика", "Из. изкуство", "ФВС"};
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 15; i++)
            {
                subjects[i] = new Label();
                subjects[i].Parent = this;
                subjects[i].Top = 70 + (i % 8) * 50;
                subjects[i].Left = (i / 8) * 150 + 50;
                subjects[i].Text = names[i];
                subjects[i].AutoSize = true;

                marks[i] = new ComboBox();
                marks[i].Parent = this;
                marks[i].Width = 100;
                marks[i].Height = 25;
                marks[i].Top = subjects[i].Top + 20;
                marks[i].Left = subjects[i].Left;

                for (int j = 2; j <= 6; j++)
                {
                    marks[i].Items.Add("освободен");
                }
                marks[i].DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            int num = 14;

            for (int i = 0; i < 14; i++)
            {
                sum += int.Parse(marks[14].Text);
                num = 15;
            }
            double average = sum / num;
            textBox1.Text = Math.Round(average, 2).ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
