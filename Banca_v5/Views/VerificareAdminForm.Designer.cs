
namespace Banca_v5.Views
{
    partial class VerificareAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerificareAdminForm));
            this.btnAutentificare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxParolaAdmin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAutentificare
            // 
            this.btnAutentificare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutentificare.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutentificare.Location = new System.Drawing.Point(48, 128);
            this.btnAutentificare.Name = "btnAutentificare";
            this.btnAutentificare.Size = new System.Drawing.Size(192, 48);
            this.btnAutentificare.TabIndex = 9;
            this.btnAutentificare.Text = "Autentificare";
            this.btnAutentificare.UseVisualStyleBackColor = true;
            this.btnAutentificare.Click += new System.EventHandler(this.btnAutentificare_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Introdu parola";
            // 
            // txtBoxParolaAdmin
            // 
            this.txtBoxParolaAdmin.Location = new System.Drawing.Point(32, 48);
            this.txtBoxParolaAdmin.MaxLength = 30;
            this.txtBoxParolaAdmin.Name = "txtBoxParolaAdmin";
            this.txtBoxParolaAdmin.Size = new System.Drawing.Size(224, 22);
            this.txtBoxParolaAdmin.TabIndex = 7;
            // 
            // VerificareAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 247);
            this.Controls.Add(this.btnAutentificare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxParolaAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VerificareAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAutentificare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxParolaAdmin;
    }
}