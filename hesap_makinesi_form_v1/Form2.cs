using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap_makinesi_form_v1
{
    public partial class Form2 : Form
    {
        Form1 frm = new Form1();
        Form3 f3 = new Form3();
        public Form2()
        {
            InitializeComponent();
        }

 

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "talha" && textBox2.Text == "a")
            {
                if (radioButton1.Checked == true)
                {
                    frm.Show();
                    this.Hide();
                }
                else if (radioButton2.Checked == true)
                {
                    f3.Show();
                    this.Hide();
                }
                else
                {
                    textBox1.Text = "Secim Yapınız";
                    textBox2.Text = "Secim Yapınız";
                }


            }
            else {
                textBox1.Text = "Yanlış Giriş";
                textBox2.Text = "Yanlış Giriş";  
                 }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           

        }

       
    }
}
