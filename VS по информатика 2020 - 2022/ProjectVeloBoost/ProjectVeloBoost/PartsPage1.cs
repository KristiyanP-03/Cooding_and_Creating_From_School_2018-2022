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
    public partial class PartsPage1 : Form
    {
        public PartsPage1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }
        double price;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Brakes")
            {
                price = 32.60;
                pictureBox1.Image = Image.FromFile("brakes.jpg");
                textBox2.Text = "Чифт спирачки. Метални.";
                textBox3.Text = price.ToString() + " лв.";
            }
            if (comboBox1.Text == "Fork")
            {
                price = 120.80;
                pictureBox1.Image = Image.FromFile("fork.jpg");
                textBox2.Text = "Предна част за велосипед.";
                textBox3.Text = price.ToString() + " лв.";
            }
            if (comboBox1.Text == "Shock")
            {
                price = 50.90;
                pictureBox1.Image = Image.FromFile("shock.jpg");
                textBox2.Text = "Амортисьор за велосипед.";
                textBox3.Text = price.ToString() + " лв.";
            }
            if (comboBox1.Text == "Wheelset")
            {
                price = 169.90;
                pictureBox1.Image = Image.FromFile("wheels.jpg");
                textBox2.Text = "Чифт джанти за велосипед.";
                textBox3.Text = price.ToString() + " лв.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Успешно поръчахте този продукт. Ще бъде доставен до адреса въведен в профила ви. Благодарим Ви ,че пазарувахте!");
        }
    }
}
