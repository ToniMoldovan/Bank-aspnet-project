
namespace Banca_v5.Views
{
    partial class TranzactiiUtilizatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranzactiiUtilizatorForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTranzExped = new System.Windows.Forms.DataGridView();
            this.dgvTranzPrimite = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranzExped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranzPrimite)).BeginInit();
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
            // dgvTranzExped
            // 
            resources.ApplyResources(this.dgvTranzExped, "dgvTranzExped");
            this.dgvTranzExped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTranzExped.Name = "dgvTranzExped";
            this.dgvTranzExped.RowTemplate.Height = 24;
            // 
            // dgvTranzPrimite
            // 
            resources.ApplyResources(this.dgvTranzPrimite, "dgvTranzPrimite");
            this.dgvTranzPrimite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTranzPrimite.Name = "dgvTranzPrimite";
            this.dgvTranzPrimite.RowTemplate.Height = 24;
            // 
            // TranzactiiUtilizatorForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTranzPrimite);
            this.Controls.Add(this.dgvTranzExped);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TranzactiiUtilizatorForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranzExped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranzPrimite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTranzExped;
        private System.Windows.Forms.DataGridView dgvTranzPrimite;
    }
}