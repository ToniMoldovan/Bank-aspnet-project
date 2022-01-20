
namespace Banca_v5.Views
{
    partial class TranzactiiGlobaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranzactiiGlobaleForm));
            this.dgvTranzactii = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranzactii)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTranzactii
            // 
            this.dgvTranzactii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTranzactii.Location = new System.Drawing.Point(33, 92);
            this.dgvTranzactii.Name = "dgvTranzactii";
            this.dgvTranzactii.RowHeadersWidth = 51;
            this.dgvTranzactii.RowTemplate.Height = 24;
            this.dgvTranzactii.Size = new System.Drawing.Size(816, 416);
            this.dgvTranzactii.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Toate tranzactiile clientilor:";
            // 
            // TranzactiiGlobaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.dgvTranzactii);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "TranzactiiGlobaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tranzactii Globale";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranzactii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTranzactii;
        private System.Windows.Forms.Label label1;
    }
}