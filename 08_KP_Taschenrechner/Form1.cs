using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_KP_Taschenrechner
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            double zahl1 = Convert.ToDouble(txtEingabe1.Text);
            double zahl2 = Convert.ToDouble(txtEingabe2.Text);
            double summe = zahl1 + zahl2;
            txtAusgabe.Text = summe.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            double zahl1 = Convert.ToDouble(txtEingabe1.Text);
            double zahl2 = Convert.ToDouble(txtEingabe2.Text);
            double minus = zahl1 - zahl2;
            txtAusgabe.Text = minus.ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            double zahl1 = Convert.ToDouble(txtEingabe1.Text);
            double zahl2 = Convert.ToDouble(txtEingabe2.Text);
            double mul = zahl1 * zahl2;
            txtAusgabe.Text = mul.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double zahl1 = Convert.ToDouble(txtEingabe1.Text);
            double zahl2 = Convert.ToDouble(txtEingabe2.Text);
            double div = zahl1 / zahl2;
            txtAusgabe.Text = div.ToString();
        }
    }
}
