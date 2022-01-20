
namespace Banca_v5
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxParola = new System.Windows.Forms.TextBox();
            this.btnAutentificare = new System.Windows.Forms.Button();
            this.lblNuAmCont = new System.Windows.Forms.Label();
            this.btnRomana = new System.Windows.Forms.Button();
            this.btnEngleza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtBoxUsername
            // 
            resources.ApplyResources(this.txtBoxUsername, "txtBoxUsername");
            this.txtBoxUsername.Name = "txtBoxUsername";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtBoxParola
            // 
            resources.ApplyResources(this.txtBoxParola, "txtBoxParola");
            this.txtBoxParola.Name = "txtBoxParola";
            this.txtBoxParola.UseSystemPasswordChar = true;
            // 
            // btnAutentificare
            // 
            resources.ApplyResources(this.btnAutentificare, "btnAutentificare");
            this.btnAutentificare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutentificare.Name = "btnAutentificare";
            this.btnAutentificare.UseVisualStyleBackColor = true;
            this.btnAutentificare.Click += new System.EventHandler(this.btnAutentificare_Click);
            // 
            // lblNuAmCont
            // 
            resources.ApplyResources(this.lblNuAmCont, "lblNuAmCont");
            this.lblNuAmCont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNuAmCont.Name = "lblNuAmCont";
            this.lblNuAmCont.Click += new System.EventHandler(this.lblNuAmCont_Click);
            this.lblNuAmCont.MouseLeave += new System.EventHandler(this.lblNuAmCont_MouseLeave);
            this.lblNuAmCont.MouseHover += new System.EventHandler(this.lblNuAmCont_MouseHover);
            // 
            // btnRomana
            // 
            resources.ApplyResources(this.btnRomana, "btnRomana");
            this.btnRomana.Name = "btnRomana";
            this.btnRomana.UseVisualStyleBackColor = true;
            this.btnRomana.Click += new System.EventHandler(this.btnRomana_Click);
            // 
            // btnEngleza
            // 
            resources.ApplyResources(this.btnEngleza, "btnEngleza");
            this.btnEngleza.Name = "btnEngleza";
            this.btnEngleza.UseVisualStyleBackColor = true;
            this.btnEngleza.Click += new System.EventHandler(this.btnEngleza_Click);
            // 
            // WelcomeForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEngleza);
            this.Controls.Add(this.btnRomana);
            this.Controls.Add(this.lblNuAmCont);
            this.Controls.Add(this.btnAutentificare);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxParola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WelcomeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WelcomeForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxParola;
        private System.Windows.Forms.Button btnAutentificare;
        private System.Windows.Forms.Label lblNuAmCont;
        private System.Windows.Forms.Button btnRomana;
        private System.Windows.Forms.Button btnEngleza;
    }
}

