using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
namespace hesap_makinesi_form_v1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "+")
            {
                int a, b, sonuc;
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
                sonuc = a + b;
                label2.Text = sonuc.ToString();
                label2.Visible = true;
            }
            else if(comboBox1.Text == "-")
            {
                int a, b, sonuc;
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
                sonuc = a - b;
                label2.Text = sonuc.ToString();
                label2.Visible = true;
            }
            else if(comboBox1.Text == "*")
            {
                int a, b, sonuc;
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
                sonuc = a * b;
                label2.Text = sonuc.ToString();
                label2.Visible = true;
            }
            else if(comboBox1.Text == "/")
            {
                int a, b, sonuc;
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
                sonuc = a /b;
                label2.Text = sonuc.ToString();
                label2.Visible = true;
            }
            else if(comboBox1.Text == "!")
            {
                int i, sayi9; BigInteger sonuc = 1;
                sayi9 = Convert.ToInt32(textBox1.Text);
                if (sayi9 == 0 || sayi9 == 1)
                {
                    sonuc = 1;
                }
                else
                {
                    for (i = 1; i <= sayi9; i++)
                    {
                        sonuc *= i;
                    }
                }

                label2.Text = sonuc.ToString();
                label2.Visible = true;
            }
            else if(comboBox1.Text == "M")
            {
                int sonuc,a,b;
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
                a = a % b;
                sonuc = a;
                label2.Text = sonuc.ToString();
                label2.Visible = true;
            }
            else if(comboBox1.Text == "L")
            {
                double a, sonuc;
                a = Convert.ToInt32(textBox1.Text);
                sonuc = Math.Log10(a);
                label2.Text = sonuc.ToString();
                label2.Visible = true;
            }
        }
    }
}
