
namespace Banca_v5.Views
{
    partial class InregistrareForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InregistrareForm));
            this.btnInregistrare = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxParola = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxNume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxPrenume = new System.Windows.Forms.TextBox();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInregistrare
            // 
            resources.ApplyResources(this.btnInregistrare, "btnInregistrare");
            this.btnInregistrare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInregistrare.Name = "btnInregistrare";
            this.btnInregistrare.UseVisualStyleBackColor = true;
            this.btnInregistrare.Click += new System.EventHandler(this.btnInregistrare_Click);
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
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtBoxNume
            // 
            resources.ApplyResources(this.txtBoxNume, "txtBoxNume");
            this.txtBoxNume.Name = "txtBoxNume";
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
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtBoxPrenume
            // 
            resources.ApplyResources(this.txtBoxPrenume, "txtBoxPrenume");
            this.txtBoxPrenume.Name = "txtBoxPrenume";
            // 
            // txtBoxUsername
            // 
            resources.ApplyResources(this.txtBoxUsername, "txtBoxUsername");
            this.txtBoxUsername.Name = "txtBoxUsername";
            // 
            // txtBoxEmail
            // 
            resources.ApplyResources(this.txtBoxEmail, "txtBoxEmail");
            this.txtBoxEmail.Name = "txtBoxEmail";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // InregistrareForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.txtBoxPrenume);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInregistrare);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxParola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxNume);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InregistrareForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InregistrareForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInregistrare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxParola;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxNume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxPrenume;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label label6;
    }
}