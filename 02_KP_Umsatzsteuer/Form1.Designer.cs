
namespace _02_KP_Umsatzsteuer
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
            this.txtEingabeNetto = new System.Windows.Forms.TextBox();
            this.txtAusgabeBrutto = new System.Windows.Forms.TextBox();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEingabeNetto
            // 
            this.txtEingabeNetto.Location = new System.Drawing.Point(317, 168);
            this.txtEingabeNetto.Name = "txtEingabeNetto";
            this.txtEingabeNetto.Size = new System.Drawing.Size(100, 22);
            this.txtEingabeNetto.TabIndex = 0;
            // 
            // txtAusgabeBrutto
            // 
            this.txtAusgabeBrutto.Location = new System.Drawing.Point(317, 229);
            this.txtAusgabeBrutto.Name = "txtAusgabeBrutto";
            this.txtAusgabeBrutto.ReadOnly = true;
            this.txtAusgabeBrutto.Size = new System.Drawing.Size(100, 22);
            this.txtAusgabeBrutto.TabIndex = 1;
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(459, 179);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(118, 59);
            this.btnBerechnen.TabIndex = 2;
            this.btnBerechnen.Text = "Bruttobetrag berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nettobetrag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bruttobetrag";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.txtAusgabeBrutto);
            this.Controls.Add(this.txtEingabeNetto);
            this.Name = "Form1";
            this.Text = "Umsatzsteuer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEingabeNetto;
        private System.Windows.Forms.TextBox txtAusgabeBrutto;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

