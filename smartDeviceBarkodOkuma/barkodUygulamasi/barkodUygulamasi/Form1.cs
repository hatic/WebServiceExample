using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace barkodUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        wsBarkod.Service1 ws = new barkodUygulamasi.wsBarkod.Service1();
        void urunBilgisi() {

            System.Data.DataSet ds = new System.Data.DataSet();
            ds = ws.barcodeBilgisi(textBoxBarkod.Text);
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Böyle bir ürün bulunamadı...");
            }
            else
            {
                textBoxUrunAdi.Text = ds.Tables[0].Rows[0]["NAME"].ToString();
            }
            textBoxBarkod.Text = "";
            textBoxBarkod.Focus();
        }
        private void buttonUrunAra_Click(object sender, EventArgs e)
        {
            urunBilgisi();

        }

        private void textBoxBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                urunBilgisi();
            }
        }
    }
}