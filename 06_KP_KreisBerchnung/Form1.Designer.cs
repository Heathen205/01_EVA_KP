
namespace _06_KP_KreisBerchnung
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
            this.txtEingabeRadius = new System.Windows.Forms.TextBox();
            this.txtAusgabeUmfang = new System.Windows.Forms.TextBox();
            this.txtAusgabeFläche = new System.Windows.Forms.TextBox();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEingabeRadius
            // 
            this.txtEingabeRadius.Location = new System.Drawing.Point(313, 81);
            this.txtEingabeRadius.Name = "txtEingabeRadius";
            this.txtEingabeRadius.Size = new System.Drawing.Size(100, 22);
            this.txtEingabeRadius.TabIndex = 0;
            // 
            // txtAusgabeUmfang
            // 
            this.txtAusgabeUmfang.Location = new System.Drawing.Point(313, 143);
            this.txtAusgabeUmfang.Name = "txtAusgabeUmfang";
            this.txtAusgabeUmfang.ReadOnly = true;
            this.txtAusgabeUmfang.Size = new System.Drawing.Size(100, 22);
            this.txtAusgabeUmfang.TabIndex = 1;
            // 
            // txtAusgabeFläche
            // 
            this.txtAusgabeFläche.Location = new System.Drawing.Point(313, 206);
            this.txtAusgabeFläche.Name = "txtAusgabeFläche";
            this.txtAusgabeFläche.ReadOnly = true;
            this.txtAusgabeFläche.Size = new System.Drawing.Size(100, 22);
            this.txtAusgabeFläche.TabIndex = 2;
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(533, 118);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(225, 76);
            this.btnBerechnen.TabIndex = 3;
            this.btnBerechnen.Text = "Berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Geben Sie den Radius an:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Der Kreisumfang beträgt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Die Fläche des Kreises beträgt:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.txtAusgabeFläche);
            this.Controls.Add(this.txtAusgabeUmfang);
            this.Controls.Add(this.txtEingabeRadius);
            this.Name = "Form1";
            this.Text = "Kreisumfang und Kreisfläche";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEingabeRadius;
        private System.Windows.Forms.TextBox txtAusgabeUmfang;
        private System.Windows.Forms.TextBox txtAusgabeFläche;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

