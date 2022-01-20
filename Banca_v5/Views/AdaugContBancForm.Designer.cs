
namespace Banca_v5.Views
{
    partial class AdaugContBancForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdaugContBancForm));
            this.txtBoxSuma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxMoneda = new System.Windows.Forms.TextBox();
            this.txtBoxPIN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdaugareCont = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxIBAN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxSuma
            // 
            this.txtBoxSuma.Location = new System.Drawing.Point(176, 256);
            this.txtBoxSuma.MaxLength = 30;
            this.txtBoxSuma.Name = "txtBoxSuma";
            this.txtBoxSuma.Size = new System.Drawing.Size(224, 31);
            this.txtBoxSuma.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(176, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Suma";
            // 
            // txtBoxMoneda
            // 
            this.txtBoxMoneda.Location = new System.Drawing.Point(176, 336);
            this.txtBoxMoneda.MaxLength = 30;
            this.txtBoxMoneda.Name = "txtBoxMoneda";
            this.txtBoxMoneda.Size = new System.Drawing.Size(224, 31);
            this.txtBoxMoneda.TabIndex = 31;
            // 
            // txtBoxPIN
            // 
            this.txtBoxPIN.Location = new System.Drawing.Point(176, 176);
            this.txtBoxPIN.MaxLength = 4;
            this.txtBoxPIN.Name = "txtBoxPIN";
            this.txtBoxPIN.Size = new System.Drawing.Size(224, 31);
            this.txtBoxPIN.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "PIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "IBAN";
            // 
            // btnAdaugareCont
            // 
            this.btnAdaugareCont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdaugareCont.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugareCont.Location = new System.Drawing.Point(192, 400);
            this.btnAdaugareCont.Name = "btnAdaugareCont";
            this.btnAdaugareCont.Size = new System.Drawing.Size(192, 48);
            this.btnAdaugareCont.TabIndex = 27;
            this.btnAdaugareCont.Text = "Creeaza cont";
            this.btnAdaugareCont.UseVisualStyleBackColor = true;
            this.btnAdaugareCont.Click += new System.EventHandler(this.btnAdaugareCont_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Moneda (RON/EURO)";
            // 
            // txtBoxIBAN
            // 
            this.txtBoxIBAN.Location = new System.Drawing.Point(176, 96);
            this.txtBoxIBAN.MaxLength = 30;
            this.txtBoxIBAN.Name = "txtBoxIBAN";
            this.txtBoxIBAN.Size = new System.Drawing.Size(224, 31);
            this.txtBoxIBAN.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 41);
            this.label1.TabIndex = 22;
            this.label1.Text = "Adaugare cont bancar";
            // 
            // AdaugContBancForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 542);
            this.Controls.Add(this.txtBoxSuma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxMoneda);
            this.Controls.Add(this.txtBoxPIN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdaugareCont);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxIBAN);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "AdaugContBancForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adauga Cont";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxSuma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxMoneda;
        private System.Windows.Forms.TextBox txtBoxPIN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdaugareCont;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxIBAN;
        private System.Windows.Forms.Label label1;
    }
}