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
    public partial class ExtragSoldContForm : Form
    {
        private int idUtil = 0;

        private DbHandler dbHandler = new DbHandler();

        private static Color culoare1 = Color.FromArgb(230, 57, 70);
        private static Color culoare2 = Color.FromArgb(241, 250, 238);
        private static Color culoare3 = Color.FromArgb(168, 218, 220);
        private static Color culoare4 = Color.FromArgb(69, 123, 157);
        private static Color culoare5 = Color.FromArgb(29, 53, 87);

        public ExtragSoldContForm(int id)
        {
            InitializeComponent();
            Actualizare();

            /*Initializare culori*/
            this.BackColor = culoare5;

            btnAdaugaSuma.BackColor = culoare1;
            btnAdaugaSuma.ForeColor = culoare2;
            btnAdaugaSuma.TabStop = false;
            btnAdaugaSuma.FlatStyle = FlatStyle.Flat;
            btnAdaugaSuma.FlatAppearance.BorderSize = 0;

            label1.ForeColor = culoare2;
            label2.ForeColor = culoare2;
            label3.ForeColor = culoare2;
            label4.ForeColor = culoare2;

            this.idUtil = id;
        }

        private async void Actualizare()
        {
            DataGridView dataGridViewActualizat = new DataGridView();

            Task<DataGridView> dataGridViewUpdateTask = new Task<DataGridView>(() => dbHandler.ActualizareConturiClient(idUtil));
            dataGridViewUpdateTask.Start();
            dataGridViewActualizat = await dataGridViewUpdateTask;

            dgvConturi.DataSource = dataGridViewActualizat.DataSource;
        }

        private async void btnAdaugaSuma_Click(object sender, EventArgs e)
        {
            int id = 0;
            double suma = 0;

            if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxCont.Text, "[^0-9]") || System.Text.RegularExpressions.Regex.IsMatch(txtBoxSuma.Text, "[^0-9]"))
            {
                MessageBox.Show("Introdu doar numere!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxCont.Clear();
            }
            else
            {
                if (txtBoxCont.TextLength == 0 || txtBoxSuma.TextLength == 0)
                {
                    MessageBox.Show("S-au detectat campuri goale!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxCont.Clear();
                    txtBoxSuma.Clear();
                }
                else
                {
                    id = int.Parse(txtBoxCont.Text);
                    suma = double.Parse(txtBoxSuma.Text);

                    //Apelare functie de extragere
                }

            }
        }
    }
}
