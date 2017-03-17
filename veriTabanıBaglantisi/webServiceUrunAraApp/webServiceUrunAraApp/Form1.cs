using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace webServiceUrunAraApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        urunAra.Service1SoapClient ws = new urunAra.Service1SoapClient();

        private void buttonUrunAra_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = ws.urunAra(textBoxUrunAdi.Text);
            dataGridViewUrunListele.DataSource=ds.Tables[0];
        }

    }
}
