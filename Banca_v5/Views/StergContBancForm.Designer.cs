
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
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnEliminareCont
            // 
            resources.ApplyResources(this.btnEliminareCont, "btnEliminareCont");
            this.btnEliminareCont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminareCont.Name = "btnEliminareCont";
            this.btnEliminareCont.UseVisualStyleBackColor = true;
            this.btnEliminareCont.Click += new System.EventHandler(this.btnEliminareCont_Click);
            // 
            // txtBoxCont
            // 
            resources.ApplyResources(this.txtBoxCont, "txtBoxCont");
            this.txtBoxCont.Name = "txtBoxCont";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dgvConturi
            // 
            resources.ApplyResources(this.dgvConturi, "dgvConturi");
            this.dgvConturi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConturi.Name = "dgvConturi";
            this.dgvConturi.RowTemplate.Height = 24;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // StergContBancForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvConturi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminareCont);
            this.Controls.Add(this.txtBoxCont);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "StergContBancForm";
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