
namespace _05_KP_Energieverbrauch
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.txtEingabeKw = new System.Windows.Forms.TextBox();
            this.txtEingabeStunden = new System.Windows.Forms.TextBox();
            this.txtEingabeTage = new System.Windows.Forms.TextBox();
            this.txtAusgabeEnerVerb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elektrische Leistung (kw)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stunden je Tag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tage pro Jahr";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Energieverbrauch (kwh)";
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(153, 246);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(197, 42);
            this.btnBerechnen.TabIndex = 4;
            this.btnBerechnen.Text = "Energieverbrauch berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // txtEingabeKw
            // 
            this.txtEingabeKw.Location = new System.Drawing.Point(338, 74);
            this.txtEingabeKw.Name = "txtEingabeKw";
            this.txtEingabeKw.Size = new System.Drawing.Size(100, 22);
            this.txtEingabeKw.TabIndex = 5;
            // 
            // txtEingabeStunden
            // 
            this.txtEingabeStunden.Location = new System.Drawing.Point(338, 135);
            this.txtEingabeStunden.Name = "txtEingabeStunden";
            this.txtEingabeStunden.Size = new System.Drawing.Size(100, 22);
            this.txtEingabeStunden.TabIndex = 6;
            // 
            // txtEingabeTage
            // 
            this.txtEingabeTage.Location = new System.Drawing.Point(338, 197);
            this.txtEingabeTage.Name = "txtEingabeTage";
            this.txtEingabeTage.Size = new System.Drawing.Size(100, 22);
            this.txtEingabeTage.TabIndex = 7;
            // 
            // txtAusgabeEnerVerb
            // 
            this.txtAusgabeEnerVerb.Location = new System.Drawing.Point(338, 307);
            this.txtAusgabeEnerVerb.Name = "txtAusgabeEnerVerb";
            this.txtAusgabeEnerVerb.ReadOnly = true;
            this.txtAusgabeEnerVerb.Size = new System.Drawing.Size(100, 22);
            this.txtAusgabeEnerVerb.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAusgabeEnerVerb);
            this.Controls.Add(this.txtEingabeTage);
            this.Controls.Add(this.txtEingabeStunden);
            this.Controls.Add(this.txtEingabeKw);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Energieverbrauch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.TextBox txtEingabeKw;
        private System.Windows.Forms.TextBox txtEingabeStunden;
        private System.Windows.Forms.TextBox txtEingabeTage;
        private System.Windows.Forms.TextBox txtAusgabeEnerVerb;
    }
}

