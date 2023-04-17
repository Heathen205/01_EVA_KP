using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_KP_inch_cm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            const double faktor = 2.54;
            double cmEin = Convert.ToDouble(txtEingabeCm.Text);
            double inchEin = Convert.ToDouble(txtEingabeInch.Text);
            double cm = 0;
            double inch = 0;
            cm = inchEin * faktor;
            inch = cmEin / faktor;

            txtAusgabeCm.Text = cm.ToString("0.00");
            txtAusgabeInch.Text = inch.ToString("0.00");
        }
    }
}
