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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp singup = new SignUp();
            singup.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                BikesPage1 bikes = new BikesPage1();
                bikes.Show();
                this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
