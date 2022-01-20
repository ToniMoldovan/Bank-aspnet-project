
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
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "AM TRIMIS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(688, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "AM PRIMIT";
            // 
            // dgvTranzExped
            // 
            this.dgvTranzExped.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTranzExped.Location = new System.Drawing.Point(32, 80);
            this.dgvTranzExped.Name = "dgvTranzExped";
            this.dgvTranzExped.RowHeadersWidth = 51;
            this.dgvTranzExped.RowTemplate.Height = 24;
            this.dgvTranzExped.Size = new System.Drawing.Size(768, 160);
            this.dgvTranzExped.TabIndex = 2;
            // 
            // dgvTranzPrimite
            // 
            this.dgvTranzPrimite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTranzPrimite.Location = new System.Drawing.Point(32, 368);
            this.dgvTranzPrimite.Name = "dgvTranzPrimite";
            this.dgvTranzPrimite.RowHeadersWidth = 51;
            this.dgvTranzPrimite.RowTemplate.Height = 24;
            this.dgvTranzPrimite.Size = new System.Drawing.Size(768, 160);
            this.dgvTranzPrimite.TabIndex = 3;
            // 
            // TranzactiiUtilizatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 553);
            this.Controls.Add(this.dgvTranzPrimite);
            this.Controls.Add(this.dgvTranzExped);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "TranzactiiUtilizatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tranzactiile mele";
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