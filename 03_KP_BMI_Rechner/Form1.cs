using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_KP_BMI_Rechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            double meter = Convert.ToDouble(txtEingabeGröße.Text);
            double kilo = Convert.ToDouble(txtEingabeGewicht.Text);
            double bmi = 0;
            bmi = kilo / (Math.Pow(meter, 2));
            txtAusgabe.Text = Math.Round(bmi, 2).ToString("0.00");
        }

        private void btnSchließen_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
