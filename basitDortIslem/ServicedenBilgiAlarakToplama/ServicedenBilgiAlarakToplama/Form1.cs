using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ServicedenBilgiAlarakToplama
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
          
            InitializeComponent();
        }
        

        private void buttonTopla_Click(object sender, EventArgs e)
        {
            wsDortIslem.Service1SoapClient ws = new wsDortIslem.Service1SoapClient();
            int a = Convert.ToInt32(textBoxSayi1.Text);
            int b = Convert.ToInt32(textBoxSayi2.Text);
            int toplam = ws.topla(a,b);
            textBoxSonuc.Text = toplam.ToString();
        }

        private void buttonCikar_Click(object sender, EventArgs e)
        {
            wsDortIslem.Service1SoapClient ws = new wsDortIslem.Service1SoapClient();
            int a = Convert.ToInt32(textBoxSayi1.Text);
            int b = Convert.ToInt32(textBoxSayi2.Text);
            int fark = ws.fark(a, b);
            textBoxSonuc.Text = fark.ToString();

        }

        private void buttonCarp_Click(object sender, EventArgs e)
        {
            wsDortIslem.Service1SoapClient ws = new wsDortIslem.Service1SoapClient();
            int a = Convert.ToInt32(textBoxSayi1.Text);
            int b = Convert.ToInt32(textBoxSayi2.Text);
            int carpim = ws.carp(a, b);
            textBoxSonuc.Text = carpim.ToString();
        }

        private void buttonBol_Click(object sender, EventArgs e)
        {
            wsDortIslem.Service1SoapClient ws = new wsDortIslem.Service1SoapClient();
            int a = Convert.ToInt32(textBoxSayi1.Text);
            int b = Convert.ToInt32(textBoxSayi2.Text);
            int bolum = ws.bol(a, b);
            textBoxSonuc.Text = bolum.ToString();
        }
    }
}
