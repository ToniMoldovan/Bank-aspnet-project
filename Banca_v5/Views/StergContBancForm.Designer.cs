
namespace Banca_v5.Views
{
    partial class StergContBancForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StergContBancForm));
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminareCont = new System.Windows.Forms.Button();
            this.txtBoxCont = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvConturi = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConturi)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "ID cont pe care doresti sa il elimini";
            // 
            // btnEliminareCont
            // 
            this.btnEliminareCont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminareCont.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminareCont.Location = new System.Drawing.Point(32, 416);
            this.btnEliminareCont.Name = "btnEliminareCont";
            this.btnEliminareCont.Size = new System.Drawing.Size(192, 48);
            this.btnEliminareCont.TabIndex = 37;
            this.btnEliminareCont.Text = "Elimina cont";
            this.btnEliminareCont.UseVisualStyleBackColor = true;
            this.btnEliminareCont.Click += new System.EventHandler(this.btnEliminareCont_Click);
            // 
            // txtBoxCont
            // 
            this.txtBoxCont.Location = new System.Drawing.Point(32, 336);
            this.txtBoxCont.MaxLength = 30;
            this.txtBoxCont.Name = "txtBoxCont";
            this.txtBoxCont.Size = new System.Drawing.Size(224, 31);
            this.txtBoxCont.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 41);
            this.label1.TabIndex = 34;
            this.label1.Text = "Eliminare cont bancar";
            // 
            // dgvConturi
            // 
            this.dgvConturi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConturi.Location = new System.Drawing.Point(32, 128);
            this.dgvConturi.Name = "dgvConturi";
            this.dgvConturi.RowHeadersWidth = 51;
            this.dgvConturi.RowTemplate.Height = 24;
            this.dgvConturi.Size = new System.Drawing.Size(656, 144);
            this.dgvConturi.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Conturi disponibile";
            // 
            // StergContBancForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 551);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvConturi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminareCont);
            this.Controls.Add(this.txtBoxCont);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "StergContBancForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sterge cont";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConturi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminareCont;
        private System.Windows.Forms.TextBox txtBoxCont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvConturi;
        private System.Windows.Forms.Label label4;
    }
}