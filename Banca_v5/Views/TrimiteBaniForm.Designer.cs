
namespace Banca_v5.Views
{
    partial class TrimiteBaniForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrimiteBaniForm));
            this.txtBoxSuma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxMoneda = new System.Windows.Forms.TextBox();
            this.txtBoxPIN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTrimite = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxIBAN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxDescriere = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxSuma
            // 
            resources.ApplyResources(this.txtBoxSuma, "txtBoxSuma");
            this.txtBoxSuma.Name = "txtBoxSuma";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // txtBoxMoneda
            // 
            resources.ApplyResources(this.txtBoxMoneda, "txtBoxMoneda");
            this.txtBoxMoneda.Name = "txtBoxMoneda";
            // 
            // txtBoxPIN
            // 
            resources.ApplyResources(this.txtBoxPIN, "txtBoxPIN");
            this.txtBoxPIN.Name = "txtBoxPIN";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnTrimite
            // 
            resources.ApplyResources(this.btnTrimite, "btnTrimite");
            this.btnTrimite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrimite.Name = "btnTrimite";
            this.btnTrimite.UseVisualStyleBackColor = true;
            this.btnTrimite.Click += new System.EventHandler(this.btnAdaugareCont_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtBoxIBAN
            // 
            resources.ApplyResources(this.txtBoxIBAN, "txtBoxIBAN");
            this.txtBoxIBAN.Name = "txtBoxIBAN";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtBoxDescriere
            // 
            resources.ApplyResources(this.txtBoxDescriere, "txtBoxDescriere");
            this.txtBoxDescriere.Name = "txtBoxDescriere";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // TrimiteBaniForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBoxDescriere);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxSuma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxMoneda);
            this.Controls.Add(this.txtBoxPIN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTrimite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxIBAN);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TrimiteBaniForm";
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
        private System.Windows.Forms.Button btnTrimite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxIBAN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxDescriere;
        private System.Windows.Forms.Label label4;
    }
}