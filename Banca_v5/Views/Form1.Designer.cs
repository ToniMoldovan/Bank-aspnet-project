﻿
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAutentificare = new System.Windows.Forms.Button();
            this.lblNuAmCont = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bun venit la banca!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Introdu datele pentru autentificare.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 30);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nume utilizator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Parola";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 288);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 30);
            this.textBox2.TabIndex = 4;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // btnAutentificare
            // 
            this.btnAutentificare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutentificare.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutentificare.Location = new System.Drawing.Point(128, 352);
            this.btnAutentificare.Name = "btnAutentificare";
            this.btnAutentificare.Size = new System.Drawing.Size(192, 48);
            this.btnAutentificare.TabIndex = 6;
            this.btnAutentificare.Text = "Autentificare";
            this.btnAutentificare.UseVisualStyleBackColor = true;
            this.btnAutentificare.Click += new System.EventHandler(this.btnAutentificare_Click);
            // 
            // lblNuAmCont
            // 
            this.lblNuAmCont.AutoSize = true;
            this.lblNuAmCont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNuAmCont.Font = new System.Drawing.Font("Gadugi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuAmCont.Location = new System.Drawing.Point(176, 448);
            this.lblNuAmCont.Name = "lblNuAmCont";
            this.lblNuAmCont.Size = new System.Drawing.Size(121, 24);
            this.lblNuAmCont.TabIndex = 7;
            this.lblNuAmCont.Text = "Nu am cont";
            this.lblNuAmCont.Click += new System.EventHandler(this.lblNuAmCont_Click);
            this.lblNuAmCont.MouseLeave += new System.EventHandler(this.lblNuAmCont_MouseLeave);
            this.lblNuAmCont.MouseHover += new System.EventHandler(this.lblNuAmCont_MouseHover);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(432, 517);
            this.Controls.Add(this.lblNuAmCont);
            this.Controls.Add(this.btnAutentificare);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnAutentificare;
        private System.Windows.Forms.Label lblNuAmCont;
    }
}
