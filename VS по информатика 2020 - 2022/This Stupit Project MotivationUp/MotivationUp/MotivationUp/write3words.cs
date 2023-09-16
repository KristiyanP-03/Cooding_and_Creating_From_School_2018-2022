using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace MotivationUp
{
    public partial class write3words : Form
    {
        public write3words()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter wr = new StreamWriter(Application.StartupPath + "\\history\\" + (textBox1.Text + ".txt"));
            wr.WriteLine("Три хубваи неща, за които се чувстваш страхотно.");
            wr.WriteLine("1. " + textBox2.Text);
            wr.WriteLine("2. " + textBox3.Text);
            wr.WriteLine("3. " + textBox4.Text);
            MessageBox.Show("Запазено! Имал си страхотен ден и дано утрешният да бъде също.");
            wr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TaskList TL = new TaskList();
            TL.Show();
            this.Hide();
        }
    }
}
