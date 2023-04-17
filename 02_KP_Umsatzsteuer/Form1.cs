using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_KP_Umsatzsteuer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            const double mwSt = 0.19;
            double netto = Convert.ToDouble(txtEingabeNetto.Text);
            double brutto = 0;
            brutto = netto + (netto * mwSt);
            txtAusgabeBrutto.Text = brutto.ToString("0.00");
        }
    }
}
