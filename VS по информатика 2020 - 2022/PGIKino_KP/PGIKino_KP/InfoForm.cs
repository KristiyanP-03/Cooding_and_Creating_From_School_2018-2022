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
    public partial class InfoForm : Form
    {
        public InfoForm(string labelText)
        {
            InitializeComponent();
            this.label5.Text = labelText;
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");
            comboBox1.Items.Add("5");
            comboBox1.Items.Add("6");
            comboBox1.Items.Add("7");
            comboBox1.Items.Add("8");
            comboBox1.Items.Add("9");
            comboBox1.Items.Add("10");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ////за името на филма
            //string CheckingFilmName = textBox1.Text;
            //Regex CheckFilmName = new Regex(@"([A-Z][a-z]+)");
            //Match matchFilmName = CheckFilmName.Match(CheckingFilmName);
            //if (matchFilmName.Success)
            //{
            //    string FilmName = textBox1.Text;
            //}
            //else
            //{
            //    MessageBox.Show("Невалиден филм !!!");
            //    textBox1.Clear();
            //}
            ////за типа на прожекцията
            //string CheckingTypeProjekciq = textBox2.Text;
            //Regex CheckTypeProjekciq = new Regex(@"([a-z]+)");
            //Match matchTypeProjekciq = CheckTypeProjekciq.Match(CheckingFilmName);
            //if (matchTypeProjekciq.Success)
            //{
            //    string TypeProjekciq = textBox2.Text;
            //}
            //else
            //{
            //    MessageBox.Show("Невалиден вид прожекция !!!");
            //    textBox2.Clear();
            //}
            
            //listbox funkciq
            if (Regex.Match(textBox1.Text,@"([A-Z][a-z]+)").Success || Regex.Match(textBox1.Text, @"([A - Z][a - z]+ [A - Z][a - z]+)").Success)
            {
                if (Regex.Match(textBox2.Text, @"([a-z]+)").Success) //не приема български
                {
                    if (textBox2.Text == "premiera")
                    {
                        listBox1.Items.Add($"{label2.Text}: {textBox1.Text}");
                        listBox1.Items.Add($"{label3.Text}: {textBox2.Text}");
                        listBox1.Items.Add($"{label4.Text}: {comboBox1.Text}");
                        Taksuvane();
                        DoburVkus();
                    }
                    else if (textBox2.Text == "normalna")
                    {
                        listBox1.Items.Add($"{label2.Text}: {textBox1.Text}");
                        listBox1.Items.Add($"{label3.Text}: {textBox2.Text}");
                        listBox1.Items.Add($"{label4.Text}: {comboBox1.Text}");
                        Taksuvane();
                        NqkuvVkus();
                    }
                    else
                    {
                        MessageBox.Show("Невалиден вид прожекция !!!");
                    }
                }
                else
                {
                    MessageBox.Show("Невалиден вид прожекция !!!");
                }
            }
            else
            {
                MessageBox.Show("Невалиден филм !!!");
            }
        }
        //metodi
        public static void DoburVkus()
        {
                MessageBox.Show("Вие сте човек с изискан вкус!");
        }
        public static void NqkuvVkus()
        {
            MessageBox.Show("И това е добър избор!");
        }
        public void Taksuvane()
        {
            if (textBox2.Text == "premiera" && (comboBox1.Text == "6" || comboBox1.Text == "7" || comboBox1.Text == "8" || comboBox1.Text == "9" || comboBox1.Text == "10"))
            {
                if (comboBox1.SelectedItem != null)
                {
                    int broiBileti = int.Parse(comboBox1.SelectedItem.ToString());
                    double suma = 0;
                    suma = broiBileti * 10.50 * 0.95;
                    listBox1.Items.Add($"Сума: {suma}");
                }
                else
                {
                    MessageBox.Show("Няма брой билети !!!");
                }
            }
            else if (textBox2.Text == "normalna")
            {
                if (comboBox1.SelectedItem != null)
                {
                    int broiBileti = int.Parse(comboBox1.SelectedItem.ToString());
                    double suma = 0;
                    suma = broiBileti * 10.50;
                    listBox1.Items.Add($"Сума: {suma}");
                }
                else
                {
                    MessageBox.Show("Няма брой билети !!!");
                }
            }
        }
        //button clear
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            listBox1.Items.Clear();
        }
        //button close
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 login = new Form1();
            login.Close();
        }
    }
}
