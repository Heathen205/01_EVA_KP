using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_KP_Einstandspreis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            double rabattPro = Convert.ToDouble(txtEingabeRabatt.Text) / 100;
            double skontoPro = Convert.ToDouble(txtEingabeSkonto.Text) / 100;
            double listenPreis = Convert.ToDouble(txtEingabeListenPreis.Text);
            double rabatt = 0;
            double zielKP = 0;
            double skonto = 0;
            double barEKP = 0;
            double transportKost = Convert.ToDouble(txtEingabeTransKos.Text);
            double einstandsPreis = 0;

            rabatt = listenPreis * rabattPro;
            zielKP = listenPreis - rabatt;

            skonto = zielKP * skontoPro;
            barEKP = zielKP - skonto;

            einstandsPreis = barEKP + transportKost;

            txtAusgabeRabatt.Text = rabatt.ToString("0.00 €");
            txtAusgabeZkp.Text = zielKP.ToString("0.00 €");
            txtAusgabeSkonto.Text = skonto.ToString("0.00 €");
            txtAusgabeBkp.Text = barEKP.ToString("0.00 €");
            txtAusgabeEinstPre.Text = einstandsPreis.ToString("0.00 €");
        }

        private void btnSchließen_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
