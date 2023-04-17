
namespace _07_KP_inch_cm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEingabeCm = new System.Windows.Forms.TextBox();
            this.txtEingabeInch = new System.Windows.Forms.TextBox();
            this.txtAusgabeCm = new System.Windows.Forms.TextBox();
            this.txtAusgabeInch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(276, 250);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(153, 57);
            this.btnBerechnen.TabIndex = 0;
            this.btnBerechnen.Text = "Berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "cm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "inch:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "inch:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(434, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "cm:";
            // 
            // txtEingabeCm
            // 
            this.txtEingabeCm.Location = new System.Drawing.Point(164, 63);
            this.txtEingabeCm.Name = "txtEingabeCm";
            this.txtEingabeCm.Size = new System.Drawing.Size(100, 22);
            this.txtEingabeCm.TabIndex = 5;
            // 
            // txtEingabeInch
            // 
            this.txtEingabeInch.Location = new System.Drawing.Point(164, 151);
            this.txtEingabeInch.Name = "txtEingabeInch";
            this.txtEingabeInch.Size = new System.Drawing.Size(100, 22);
            this.txtEingabeInch.TabIndex = 6;
            // 
            // txtAusgabeCm
            // 
            this.txtAusgabeCm.Location = new System.Drawing.Point(543, 151);
            this.txtAusgabeCm.Name = "txtAusgabeCm";
            this.txtAusgabeCm.ReadOnly = true;
            this.txtAusgabeCm.Size = new System.Drawing.Size(100, 22);
            this.txtAusgabeCm.TabIndex = 8;
            // 
            // txtAusgabeInch
            // 
            this.txtAusgabeInch.Location = new System.Drawing.Point(543, 63);
            this.txtAusgabeInch.Name = "txtAusgabeInch";
            this.txtAusgabeInch.ReadOnly = true;
            this.txtAusgabeInch.Size = new System.Drawing.Size(100, 22);
            this.txtAusgabeInch.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAusgabeCm);
            this.Controls.Add(this.txtAusgabeInch);
            this.Controls.Add(this.txtEingabeInch);
            this.Controls.Add(this.txtEingabeCm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBerechnen);
            this.Name = "Form1";
            this.Text = "Inch-Cm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEingabeCm;
        private System.Windows.Forms.TextBox txtEingabeInch;
        private System.Windows.Forms.TextBox txtAusgabeCm;
        private System.Windows.Forms.TextBox txtAusgabeInch;
    }
}

