using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banca_v5.Views;
using Banca_v5.Models;

namespace Banca_v5.Views
{
    public partial class PrincipalForm : Form
    {
        private DbHandler dbHandler = new DbHandler();
        private int idUtil = 0;

        private static Color culoare1 = Color.FromArgb(230, 57, 70);
        private static Color culoare2 = Color.FromArgb(241, 250, 238);
        private static Color culoare3 = Color.FromArgb(168, 218, 220);
        private static Color culoare4 = Color.FromArgb(69, 123, 157);
        private static Color culoare5 = Color.FromArgb(29, 53, 87);

        public PrincipalForm(string numeUtilizator, int idUtilizator)
        {
            InitializeComponent();

            if (numeUtilizator != null)
            {
                idUtil = idUtilizator;
                lblSalutare.Text = ($"Salutare, {numeUtilizator}!");
            }

            /*Setare culori*/
            this.BackColor = culoare5;
            this.panelUser.BackColor = culoare4;
            
            lblSalutare.ForeColor = culoare2;

            label1.ForeColor = culoare2;
            label2.ForeColor = culoare2;

            btnAdaugaContBancar.BackColor = culoare1;
            btnAdaugaContBancar.ForeColor = culoare2;
            btnAdaugaContBancar.TabStop = false;
            btnAdaugaContBancar.FlatStyle = FlatStyle.Flat;
            btnAdaugaContBancar.FlatAppearance.BorderSize = 0;

            btnAdaugaSoldInCont.BackColor = culoare1;
            btnAdaugaSoldInCont.ForeColor = culoare2;
            btnAdaugaSoldInCont.TabStop = false;
            btnAdaugaSoldInCont.FlatStyle = FlatStyle.Flat;
            btnAdaugaSoldInCont.FlatAppearance.BorderSize = 0;

            btnStergeContBancar.BackColor = culoare1;
            btnStergeContBancar.ForeColor = culoare2;
            btnStergeContBancar.TabStop = false;
            btnStergeContBancar.FlatStyle = FlatStyle.Flat;
            btnStergeContBancar.FlatAppearance.BorderSize = 0;

            btnExtrageSold.BackColor = culoare1;
            btnExtrageSold.ForeColor = culoare2;
            btnExtrageSold.TabStop = false;
            btnExtrageSold.FlatStyle = FlatStyle.Flat;
            btnExtrageSold.FlatAppearance.BorderSize = 0;
        }

        private void copyrightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dezvoltatori:\n\n\nMoldovan Antonio - Front-End\n\nNoje Ionut - Back-End\n\nMilu Iancu - Back-End\n\nVersiune: 1.0", 
                            "Copyright", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello! :)", "Yes", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tranzactiileMeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilizator utilizator = dbHandler.GetUtilizator(idUtil);

            TranzactiiUtilizatorForm tranzactiiUtilizator = new TranzactiiUtilizatorForm(utilizator.IdCont);
            tranzactiiUtilizator.ShowDialog();
        }

        private void clientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerificareAdminForm verificareAdminForm = new VerificareAdminForm();

            if (verificareAdminForm.ShowDialog() == DialogResult.OK)
            {
                AfisareClientiForm afisareClienti = new AfisareClientiForm();
                afisareClienti.Show();
            }
        }

        private void tranzactiiGlobaleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAdaugaContBancar_Click(object sender, EventArgs e)
        {
            AdaugContBancForm adaugCont = new AdaugContBancForm();
            adaugCont.ShowDialog();
        }

        private void btnStergeContBancar_Click(object sender, EventArgs e)
        {
            StergContBancForm stergContBanc = new StergContBancForm(idUtil);
            stergContBanc.ShowDialog();
        }

        private void btnAdaugaSoldInCont_Click(object sender, EventArgs e)
        {
            AdaugSoldContForm adaugSoldCont = new AdaugSoldContForm(idUtil);
            adaugSoldCont.ShowDialog();
        }

        private void btnExtrageSold_Click(object sender, EventArgs e)
        {
            ExtragSoldContForm extragSoldCont = new ExtragSoldContForm(idUtil);
            extragSoldCont.ShowDialog();
        }

        private void trimiteBaniToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        //Incerc sa creez un ceas
        /*
        System.Windows.Forms.Timer t = null;

        private void StartTimer()
        {
            t = new System.Windows.Forms.Timer();
            t.Tick += new EventHandler(timer1_Tick);
            t.Interval = 1000;
            t.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblOraModificata.Text = DateTime.UtcNow.ToString("hh:mm:ss tt");
        }
        */
    }
}
