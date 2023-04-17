
namespace _03_KP_BMI_Rechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.btnSchließen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEingabeGröße = new System.Windows.Forms.TextBox();
            this.txtEingabeGewicht = new System.Windows.Forms.TextBox();
            this.txtAusgabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(253, 192);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(192, 44);
            this.btnBerechnen.TabIndex = 0;
            this.btnBerechnen.Text = "BMI berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // btnSchließen
            // 
            this.btnSchließen.Location = new System.Drawing.Point(253, 328);
            this.btnSchließen.Name = "btnSchließen";
            this.btnSchließen.Size = new System.Drawing.Size(192, 42);
            this.btnSchließen.TabIndex = 1;
            this.btnSchließen.Text = "Schließen";
            this.btnSchließen.UseVisualStyleBackColor = true;
            this.btnSchließen.Click += new System.EventHandler(this.btnSchließen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Größe in meter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gewicht in Kg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ihr BMI ist";
            // 
            // txtEingabeGröße
            // 
            this.txtEingabeGröße.Location = new System.Drawing.Point(398, 56);
            this.txtEingabeGröße.Name = "txtEingabeGröße";
            this.txtEingabeGröße.Size = new System.Drawing.Size(100, 22);
            this.txtEingabeGröße.TabIndex = 5;
            // 
            // txtEingabeGewicht
            // 
            this.txtEingabeGewicht.Location = new System.Drawing.Point(398, 130);
            this.txtEingabeGewicht.Name = "txtEingabeGewicht";
            this.txtEingabeGewicht.Size = new System.Drawing.Size(100, 22);
            this.txtEingabeGewicht.TabIndex = 6;
            // 
            // txtAusgabe
            // 
            this.txtAusgabe.Location = new System.Drawing.Point(398, 270);
            this.txtAusgabe.Name = "txtAusgabe";
            this.txtAusgabe.ReadOnly = true;
            this.txtAusgabe.Size = new System.Drawing.Size(100, 22);
            this.txtAusgabe.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAusgabe);
            this.Controls.Add(this.txtEingabeGewicht);
            this.Controls.Add(this.txtEingabeGröße);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSchließen);
            this.Controls.Add(this.btnBerechnen);
            this.Name = "Form1";
            this.Text = "BMI-Rechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.Button btnSchließen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEingabeGröße;
        private System.Windows.Forms.TextBox txtEingabeGewicht;
        private System.Windows.Forms.TextBox txtAusgabe;
    }
}

