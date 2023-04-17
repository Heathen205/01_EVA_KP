using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_KP_Energieverbrauch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            double kw = Convert.ToDouble(txtEingabeKw.Text);
            double stunden = Convert.ToDouble(txtEingabeStunden.Text);
            double tage = Convert.ToDouble(txtEingabeTage.Text);
            double verbrauch = 0;
            verbrauch = kw * stunden * tage;
            txtAusgabeEnerVerb.Text = verbrauch.ToString("0.00");
        }
    }
}
