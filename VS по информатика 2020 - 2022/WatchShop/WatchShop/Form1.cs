using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WatchShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
//Watches price
        double price = 0;
        double bprice = 0;
        double sprice = 0;
        double totalprice = 0;
//Help
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Добре дошли в онлайн магазина за ръчни часовници  Watch Shop.Нашия онлайн магазин предлага 3 марки часовници ( Classic MVMT, DOT collection и Special editions)." + Environment.NewLine + "От менюто Watch Brands избирате една от трите марки часовници, които предлагаме в нашия магазин. След като изберете марка, в падащото меню под Available watches са изброени всички налични часовници от дадените марки в магазина и цената се показва под името на часовника , а в дясно картинка на самия часовник и кратко описание.   От менюто Add - ons for your watch може да закупите допълнително резервна батерия или каишка, а цената ще се покаже в дясно. Ако искате да узнаете повече за доставката, с помощта  на менюто Important information about shipping ще ви излезе подробна и важна информация относно доставката, а с помощта на  менюто Pay method избирате начина на плащане. Опцията Delivery date ви допитва за удобна за вас дата на доставка като работното време на магазина е разпределено по следния начин:" + Environment.NewLine + "Понеделник – Четвъртък:  9:00 – 20:00.Петък – Неделя: почивни дни; " + Environment.NewLine + " След като сте готови с покупката, с опцията Check out ще ви бъде изчислена крайната сума  и ще ви издаде касова бележка, която трябва да представите на наш куриер. Ако искате да се откажете от покупката си, може да използвате бутона Cancel and Clean, който ще прекрати вашата заявка и ще рестартира въведената от вас информация.");
        }
//Тип часовник
     // Classic watches
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                comboBox1.Items.Add("Classic black leather");
                comboBox1.Items.Add("Classic black tan");
                comboBox1.Items.Add("Classic monochrome link");
            }
            else if (radioButton1.Checked == false)
            {
                comboBox1.Text = "";
                comboBox1.Items.Clear();
                pictureBox1.Image = null;
                textBox3.Text = "";
                textBox1.Text = "";
            }
        }
     //DOT women collection
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                comboBox1.Items.Add("DOT nomad");
                comboBox1.Items.Add("Verve");
                comboBox1.Items.Add("Vibe");
            }
            else if (radioButton1.Checked == false)
            {
                comboBox1.Text = "";
                comboBox1.Items.Clear();
                pictureBox1.Image = null;
                textBox3.Text = "";
                textBox1.Text = "";
            }
        }
     //Special editions
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                comboBox1.Items.Add("Nyjah Edition");
                comboBox1.Items.Add("Cole Edition");
            }
            else if (radioButton3.Checked == false)
            {
                comboBox1.Text = "";
                comboBox1.Items.Clear();
                pictureBox1.Image = null;
                textBox3.Text = "";
                textBox1.Text = "";
            }
        }
// Pictures
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         // Classic watches
            if (comboBox1.Text == "Classic black leather")
            {
                price = 176.64;
                pictureBox1.Image = Image.FromFile("Classicblackleather.jpg");
                textBox1.Text = "MVMT's pioneer flagship design. The Classic�s clean 45mm dial and simple sophistication have become an icon. Featuring an all-black colorway with pops of red dial accents and brushed stainless steel for a satin finish. ";
                textBox3.Text = price.ToString() + "$"; 
            }
            else if (comboBox1.Text == "Classic black tan")
            {
                price = 163.25;
                pictureBox1.Image = Image.FromFile("classicblacktan.jpg");
                textBox1.Text = "MVMT's pioneer flagship design. The Classic's clean 45mm dial and simple sophistication have become an icon. Featuring a signature MVMT color combo — rich tan leather contrasted by a striking black dial with subtle pops of red. ";
                textBox3.Text = price.ToString() + "$";
            }
            else if (comboBox1.Text == "Classic monochrome link")
            {
                price = 213.44;
                pictureBox1.Image = Image.FromFile("classicmonochromelink.jpg");
                textBox1.Text = "MVMT's pioneer flagship design. The Classic�s clean 45mm dial and simple sophistication have become an icon. Featuring a monochrome colorway that takes its tones from urban architecture and industrial city streets. ";
                textBox3.Text = price.ToString() + "$";
            }
         //DOT women collection
            else if (comboBox1.Text == "DOT nomad")
            {
                price = 182.49;
                pictureBox1.Image = Image.FromFile("dotnomad.jpg");
                textBox1.Text = "Soft and sweet that packs a punch. This fits-just-right 36mm design features domed dial markers, a curved silhouette and a softly sculpted crown inspired by the Collection's dot motif. The Dot Nomad wears a special edition beige gold metal and tan leather colorway.";
                textBox3.Text = price.ToString() + "$";
            }
            else if (comboBox1.Text == "Verve")
            {
                price = 182.45;
                pictureBox1.Image = Image.FromFile("verve.jpg");
                textBox1.Text = "The perfect women’s watch for both casual and formal settings. Made to pair with our bracelets and necklaces, the Verve watch for women features a rose gold watch case, light grey leather watch strap and white dial. ";
                textBox3.Text = price.ToString() + "$";
            }
            else if (comboBox1.Text == "Vibe")
            {
                price = 220.45;
                pictureBox1.Image = Image.FromFile("vibe.jpg");
                textBox1.Text = "Soft and sweet that packs a punch. This fits-just-right 36mm design features domed dial markers, a curved silhouette and a softly sculpted crown inspired by the Collection's dot motif. The Vibe wears MVMT's first wine purple and rose gold colorway.";
                textBox3.Text = price.ToString() + "$";
            }
         //Special editions
            else if (comboBox1.Text == "Nyjah Edition")
            {
                price = 365.89;
                pictureBox1.Image = Image.FromFile("nyjahedition.jpg");
                textBox1.Text = "In true Nyjah fashion, he went all in designing his first signature watch. The street skater's urban stomping grounds are embodied by the design's gunmetal steel, pebbled asphalt leather and interchangeable chain link mesh strap. The pops of blue on the dial are pulled from the same blues on Nyjah's automobiles. Its tactical chronograph movement and 10 ATM water resistant case are built for any path or obstacle. Symbols inspired by Nyjah's own ink are embossed on the straps. ";
                textBox3.Text = price.ToString() + "$";
            }
            else if (comboBox1.Text == "Cole Edition")
            {
                price = 345.89;
                pictureBox1.Image = Image.FromFile("coleedition.jpg");
                textBox1.Text = "Hybrid Modern Sport dive case with 40 Series dial. Jeff Cole signature owl stamped on the dial, strap and caseback. Two-tone black and white color set. Utilitarian rubber and business-forward leather interchangeable strap options. Crystalized bezel for glossed-out finish. Custom box set designed by the artist. ";
                textBox3.Text = price.ToString() + "$";
            }
        }
//Add-ons for your watch
        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                bprice = 39.99;
                textBox5.Text = "+" + bprice.ToString() + "$";
            }
            else if (checkBox1.Checked == false)
            {
                textBox5.Text = "";
                bprice = 0;
            }
        }

        public void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                sprice = 59.99;
                textBox6.Text = "+" + sprice.ToString() + "$";
            }
            else if (checkBox2.Checked == false)
            {
                textBox6.Text = "";
                sprice = 0;
            }
        }
//Check out
        public void button1_Click(object sender, EventArgs e)
        {

            totalprice = price + bprice + sprice;
            MessageBox.Show("E-mail address: " + textBox8.Text + Environment.NewLine + "Mobile number: " + textBox4.Text + Environment.NewLine + "Street address: " + richTextBox1.Text + Environment.NewLine + Environment.NewLine + "Item: " + comboBox1.Text + Environment.NewLine + "Delivery date: " + dateTimePicker1.Text + Environment.NewLine + Environment.NewLine + "Total price: " + totalprice + "$" , "Check out " + Environment.NewLine + " Thank you for shopping with us! :)");
        }
//Cancel and clear
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox8.Text = "";
            richTextBox1.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            pictureBox1.Image = null;
            comboBox1.Text = "";
            comboBox1.Items.Clear();
        }
    }
}
