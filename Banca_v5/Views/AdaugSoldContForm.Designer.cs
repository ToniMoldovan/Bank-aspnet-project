
namespace Banca_v5.Views
{
    partial class AdaugSoldContForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdaugSoldContForm));
            this.label4 = new System.Windows.Forms.Label();
            this.dgvConturi = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdaugaSuma = new System.Windows.Forms.Button();
            this.txtBoxCont = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxSuma = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConturi)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Conturi disponibile";
            // 
            // dgvConturi
            // 
            this.dgvConturi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConturi.Location = new System.Drawing.Point(48, 112);
            this.dgvConturi.Name = "dgvConturi";
            this.dgvConturi.RowHeadersWidth = 51;
            this.dgvConturi.RowTemplate.Height = 24;
            this.dgvConturi.Size = new System.Drawing.Size(656, 144);
            this.dgvConturi.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "ID cont";
            // 
            // btnAdaugaSuma
            // 
            this.btnAdaugaSuma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdaugaSuma.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaSuma.Location = new System.Drawing.Point(512, 416);
            this.btnAdaugaSuma.Name = "btnAdaugaSuma";
            this.btnAdaugaSuma.Size = new System.Drawing.Size(192, 48);
            this.btnAdaugaSuma.TabIndex = 48;
            this.btnAdaugaSuma.Text = "Adauga sold";
            this.btnAdaugaSuma.UseVisualStyleBackColor = true;
            this.btnAdaugaSuma.Click += new System.EventHandler(this.btnAdaugaSuma_Click);
            // 
            // txtBoxCont
            // 
            this.txtBoxCont.Location = new System.Drawing.Point(48, 304);
            this.txtBoxCont.MaxLength = 30;
            this.txtBoxCont.Name = "txtBoxCont";
            this.txtBoxCont.Size = new System.Drawing.Size(224, 31);
            this.txtBoxCont.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 41);
            this.label1.TabIndex = 46;
            this.label1.Text = "Adaugare sold";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Suma";
            // 
            // txtBoxSuma
            // 
            this.txtBoxSuma.Location = new System.Drawing.Point(48, 416);
            this.txtBoxSuma.MaxLength = 30;
            this.txtBoxSuma.Name = "txtBoxSuma";
            this.txtBoxSuma.Size = new System.Drawing.Size(224, 31);
            this.txtBoxSuma.TabIndex = 52;
            // 
            // AdaugSoldContForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 475);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxSuma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvConturi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdaugaSuma);
            this.Controls.Add(this.txtBoxCont);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "AdaugSoldContForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adauga sold";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConturi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvConturi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdaugaSuma;
        private System.Windows.Forms.TextBox txtBoxCont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxSuma;
    }
}