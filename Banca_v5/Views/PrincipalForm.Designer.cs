
namespace Banca_v5.Views
{
    partial class PrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyrightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operatiuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tranzactiileMeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conturileMeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tranzactiiGlobaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSalutare = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.btnAdaugaContBancar = new System.Windows.Forms.Button();
            this.btnStergeContBancar = new System.Windows.Forms.Button();
            this.btnAdaugaSoldInCont = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSoldEuro = new System.Windows.Forms.Label();
            this.lblSoldRon = new System.Windows.Forms.Label();
            this.btnExtrageSold = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniuToolStripMenuItem,
            this.operatiuniToolStripMenuItem,
            this.administratorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniuToolStripMenuItem
            // 
            this.meniuToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.meniuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyrightsToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.meniuToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.meniuToolStripMenuItem.Name = "meniuToolStripMenuItem";
            this.meniuToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.meniuToolStripMenuItem.Text = "Meniu";
            // 
            // copyrightsToolStripMenuItem
            // 
            this.copyrightsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyrightsToolStripMenuItem.Image")));
            this.copyrightsToolStripMenuItem.Name = "copyrightsToolStripMenuItem";
            this.copyrightsToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.copyrightsToolStripMenuItem.Text = "Copyright";
            this.copyrightsToolStripMenuItem.Click += new System.EventHandler(this.copyrightsToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("iesireToolStripMenuItem.Image")));
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // operatiuniToolStripMenuItem
            // 
            this.operatiuniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tranzactiileMeleToolStripMenuItem,
            this.conturileMeleToolStripMenuItem});
            this.operatiuniToolStripMenuItem.Name = "operatiuniToolStripMenuItem";
            this.operatiuniToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.operatiuniToolStripMenuItem.Text = "Operatiuni";
            // 
            // tranzactiileMeleToolStripMenuItem
            // 
            this.tranzactiileMeleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tranzactiileMeleToolStripMenuItem.Image")));
            this.tranzactiileMeleToolStripMenuItem.Name = "tranzactiileMeleToolStripMenuItem";
            this.tranzactiileMeleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tranzactiileMeleToolStripMenuItem.Text = "Tranzactiile mele";
            this.tranzactiileMeleToolStripMenuItem.Click += new System.EventHandler(this.tranzactiileMeleToolStripMenuItem_Click);
            // 
            // conturileMeleToolStripMenuItem
            // 
            this.conturileMeleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("conturileMeleToolStripMenuItem.Image")));
            this.conturileMeleToolStripMenuItem.Name = "conturileMeleToolStripMenuItem";
            this.conturileMeleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.conturileMeleToolStripMenuItem.Text = "Conturile mele";
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tranzactiiGlobaleToolStripMenuItem,
            this.clientiToolStripMenuItem});
            this.administratorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("administratorToolStripMenuItem.Image")));
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.administratorToolStripMenuItem.Text = "Administrator";
            // 
            // tranzactiiGlobaleToolStripMenuItem
            // 
            this.tranzactiiGlobaleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tranzactiiGlobaleToolStripMenuItem.Image")));
            this.tranzactiiGlobaleToolStripMenuItem.Name = "tranzactiiGlobaleToolStripMenuItem";
            this.tranzactiiGlobaleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tranzactiiGlobaleToolStripMenuItem.Text = "Tranzactii globale";
            this.tranzactiiGlobaleToolStripMenuItem.Click += new System.EventHandler(this.tranzactiiGlobaleToolStripMenuItem_Click);
            // 
            // clientiToolStripMenuItem
            // 
            this.clientiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientiToolStripMenuItem.Image")));
            this.clientiToolStripMenuItem.Name = "clientiToolStripMenuItem";
            this.clientiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clientiToolStripMenuItem.Text = "Clienti";
            this.clientiToolStripMenuItem.Click += new System.EventHandler(this.clientiToolStripMenuItem_Click);
            // 
            // lblSalutare
            // 
            this.lblSalutare.AutoSize = true;
            this.lblSalutare.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalutare.Location = new System.Drawing.Point(688, 224);
            this.lblSalutare.Name = "lblSalutare";
            this.lblSalutare.Size = new System.Drawing.Size(93, 21);
            this.lblSalutare.TabIndex = 1;
            this.lblSalutare.Text = "Salutare, ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(720, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.btnExtrageSold);
            this.panelUser.Controls.Add(this.btnStergeContBancar);
            this.panelUser.Controls.Add(this.btnAdaugaSoldInCont);
            this.panelUser.Controls.Add(this.btnAdaugaContBancar);
            this.panelUser.Controls.Add(this.pictureBox1);
            this.panelUser.Controls.Add(this.lblSalutare);
            this.panelUser.Location = new System.Drawing.Point(0, 304);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(912, 272);
            this.panelUser.TabIndex = 3;
            // 
            // btnAdaugaContBancar
            // 
            this.btnAdaugaContBancar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdaugaContBancar.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaContBancar.Location = new System.Drawing.Point(16, 64);
            this.btnAdaugaContBancar.Name = "btnAdaugaContBancar";
            this.btnAdaugaContBancar.Size = new System.Drawing.Size(240, 48);
            this.btnAdaugaContBancar.TabIndex = 4;
            this.btnAdaugaContBancar.Text = "Adauga cont bancar";
            this.btnAdaugaContBancar.UseVisualStyleBackColor = true;
            // 
            // btnStergeContBancar
            // 
            this.btnStergeContBancar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStergeContBancar.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergeContBancar.Location = new System.Drawing.Point(16, 144);
            this.btnStergeContBancar.Name = "btnStergeContBancar";
            this.btnStergeContBancar.Size = new System.Drawing.Size(240, 48);
            this.btnStergeContBancar.TabIndex = 5;
            this.btnStergeContBancar.Text = "Sterge cont bancar";
            this.btnStergeContBancar.UseVisualStyleBackColor = true;
            // 
            // btnAdaugaSoldInCont
            // 
            this.btnAdaugaSoldInCont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdaugaSoldInCont.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaSoldInCont.Location = new System.Drawing.Point(288, 64);
            this.btnAdaugaSoldInCont.Name = "btnAdaugaSoldInCont";
            this.btnAdaugaSoldInCont.Size = new System.Drawing.Size(240, 48);
            this.btnAdaugaSoldInCont.TabIndex = 6;
            this.btnAdaugaSoldInCont.Text = "Adauga sold in cont";
            this.btnAdaugaSoldInCont.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sold curent EURO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sold curent RON:";
            // 
            // lblSoldEuro
            // 
            this.lblSoldEuro.AutoSize = true;
            this.lblSoldEuro.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoldEuro.Location = new System.Drawing.Point(240, 144);
            this.lblSoldEuro.Name = "lblSoldEuro";
            this.lblSoldEuro.Size = new System.Drawing.Size(25, 21);
            this.lblSoldEuro.TabIndex = 9;
            this.lblSoldEuro.Text = "...";
            // 
            // lblSoldRon
            // 
            this.lblSoldRon.AutoSize = true;
            this.lblSoldRon.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoldRon.Location = new System.Drawing.Point(240, 192);
            this.lblSoldRon.Name = "lblSoldRon";
            this.lblSoldRon.Size = new System.Drawing.Size(25, 21);
            this.lblSoldRon.TabIndex = 10;
            this.lblSoldRon.Text = "...";
            // 
            // btnExtrageSold
            // 
            this.btnExtrageSold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExtrageSold.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtrageSold.Location = new System.Drawing.Point(288, 144);
            this.btnExtrageSold.Name = "btnExtrageSold";
            this.btnExtrageSold.Size = new System.Drawing.Size(240, 48);
            this.btnExtrageSold.TabIndex = 7;
            this.btnExtrageSold.Text = "Extrage sold din cont";
            this.btnExtrageSold.UseVisualStyleBackColor = true;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 563);
            this.Controls.Add(this.lblSoldRon);
            this.Controls.Add(this.lblSoldEuro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banca | Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operatiuniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tranzactiileMeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meniuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyrightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tranzactiiGlobaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientiToolStripMenuItem;
        private System.Windows.Forms.Label lblSalutare;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem conturileMeleToolStripMenuItem;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Button btnStergeContBancar;
        private System.Windows.Forms.Button btnAdaugaSoldInCont;
        private System.Windows.Forms.Button btnAdaugaContBancar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSoldEuro;
        private System.Windows.Forms.Label lblSoldRon;
        private System.Windows.Forms.Button btnExtrageSold;
    }
}