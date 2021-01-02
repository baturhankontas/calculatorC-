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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesapButon_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(sayi1textbox.Text);
            int sayi2 = Convert.ToInt32(sayi2textbox.Text);
            int sonuc;
            sonuc = sayi1 + sayi2;
            sonuc2.Text = sonuc.ToString();
            sonuc2.Visible = true;
        }

        private void cikarmaButon_Click(object sender, EventArgs e)
        {
            int sayi3 = Convert.ToInt32(sayi1textbox.Text);
            int sayi4 = Convert.ToInt32(sayi2textbox.Text);
            int sonuc;
            sonuc = sayi3 - sayi4;
            sonuc2.Text = sonuc.ToString();
            sonuc2.Visible = true;
        }

        private void carpmaButon_Click(object sender, EventArgs e)
        {
            int sayi5 = Convert.ToInt32(sayi1textbox.Text);
            int sayi6 = Convert.ToInt32(sayi2textbox.Text);
            int sonuc = 1;
            sonuc = (sayi5 * sayi6);
            sonuc2.Text = sonuc.ToString();
            sonuc2.Visible = true;
        }

        private void bolmeButon_Click(object sender, EventArgs e)
        {
            int sayi7 = Convert.ToInt32(sayi1textbox.Text);
            int sayi8 = Convert.ToInt32(sayi2textbox.Text);
            int sonuc;
            sonuc = (sayi7 / sayi8);
            sonuc2.Text = sonuc.ToString();
            sonuc2.Visible = true;
        }

        private void faktoriyelButon_Click(object sender, EventArgs e)
        {
            int i, sayi9; BigInteger sonuc = 1;
            sayi9 = Convert.ToInt32(sayi1textbox.Text);
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

            sonuc2.Text = sonuc.ToString();
            sonuc2.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
