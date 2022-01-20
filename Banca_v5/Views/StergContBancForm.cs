using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banca_v5.Models;

namespace Banca_v5.Views
{
    public partial class StergContBancForm : Form
    {
        private int idUtil = 0;

        private DbHandler dbHandler = new DbHandler();

        private static Color culoare1 = Color.FromArgb(230, 57, 70);
        private static Color culoare2 = Color.FromArgb(241, 250, 238);
        private static Color culoare3 = Color.FromArgb(168, 218, 220);
        private static Color culoare4 = Color.FromArgb(69, 123, 157);
        private static Color culoare5 = Color.FromArgb(29, 53, 87);

        public StergContBancForm(int idUtilizator)
        {
            InitializeComponent();
            Actualizare();

            /*Initializare culori*/
            this.BackColor = culoare5;

            btnEliminareCont.BackColor = culoare1;
            btnEliminareCont.ForeColor = culoare2;
            btnEliminareCont.TabStop = false;
            btnEliminareCont.FlatStyle = FlatStyle.Flat;
            btnEliminareCont.FlatAppearance.BorderSize = 0;

            label1.ForeColor = culoare2;
            label2.ForeColor = culoare2;
            label4.ForeColor = culoare2;

            this.idUtil = idUtilizator;
        }

        private async void Actualizare()
        {
            DataGridView dataGridViewActualizat = new DataGridView();

            Task<DataGridView> dataGridViewUpdateTask = new Task<DataGridView>(() => dbHandler.ActualizareConturiClient(idUtil));
            dataGridViewUpdateTask.Start();
            dataGridViewActualizat = await dataGridViewUpdateTask;

            dgvConturi.DataSource = dataGridViewActualizat.DataSource;
        }

        private async void btnEliminareCont_Click(object sender, EventArgs e)
        {
            int idCont = 0;

            if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxCont.Text, "[^0-9]"))
            {
                MessageBox.Show("Introdu doar numere!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxCont.Clear();
            }
            else
            {
                idCont = int.Parse(txtBoxCont.Text);
                //Apelare functie de stergere
            }
        }
    }
}
