using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_KP_KreisBerchnung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(txtEingabeRadius.Text);
            double umfang = 0;
            double fläche = 0;
            umfang = 2 * Math.PI * radius;
            fläche = Math.PI * Math.Pow(radius, 2);
            txtAusgabeFläche.Text = fläche.ToString("0.00");
            txtAusgabeUmfang.Text = umfang.ToString("0.00");
        }
    }
}
