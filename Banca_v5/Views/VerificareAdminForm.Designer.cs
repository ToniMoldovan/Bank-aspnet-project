
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
            resources.ApplyResources(this.btnAutentificare, "btnAutentificare");
            this.btnAutentificare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutentificare.Name = "btnAutentificare";
            this.btnAutentificare.UseVisualStyleBackColor = true;
            this.btnAutentificare.Click += new System.EventHandler(this.btnAutentificare_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtBoxParolaAdmin
            // 
            resources.ApplyResources(this.txtBoxParolaAdmin, "txtBoxParolaAdmin");
            this.txtBoxParolaAdmin.Name = "txtBoxParolaAdmin";
            // 
            // VerificareAdminForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAutentificare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxParolaAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "VerificareAdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAutentificare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxParolaAdmin;
    }
}