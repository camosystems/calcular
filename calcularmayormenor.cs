using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label3.Text = "falta un numero";
                textBox3.Clear();
                return;
            }
             if (textBox2.Text =="")
            {
                label2.Text = "falta un numero";
                textBox3.Clear();
                return;
            }
            double num1, num2, num3;
            num1 = double.Parse(textBox1.Text);
            num2 = double.Parse(textBox2.Text);
            if (num1 < num2)
            {
                textBox3.Text = num2.ToString();
                label1.Text = "resultado";
                label2.Text = "mayor";
                label3.Text = "menor";
            }
            else
            {
                textBox3.Text = num1.ToString();
                label3.Text = "Mayor";
                label2.Text = "Menor";
            }
            if (num1 == num2)
            {
                label3.Text = "mismo numero";
                label2.Text = "mismo numero";
                textBox3.Clear();
            }
            else
            {
                num3 = double.Parse(textBox3.Text.ToString());
                label1.Text = "resultado";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Clear();
                }
            }
        }

        private void a(object sender, KeyPressEventArgs e)
        {

        }
    }
}