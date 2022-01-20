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
    public partial class TranzactiiUtilizatorForm : Form
    {
        DbHandler dbHandler = new DbHandler();

        private static Color culoare1 = Color.FromArgb(230, 57, 70);
        private static Color culoare2 = Color.FromArgb(241, 250, 238);
        private static Color culoare3 = Color.FromArgb(168, 218, 220);
        private static Color culoare4 = Color.FromArgb(69, 123, 157);
        private static Color culoare5 = Color.FromArgb(29, 53, 87);

        private int idContUtilizator = 0;

        public TranzactiiUtilizatorForm(int idCont) //Va trebui sa primeasca idCont
        {
            InitializeComponent();
            ActualizarePrimite();
            ActualizareTrimise();

            this.BackColor = culoare5;
            label1.ForeColor = culoare1;
            label2.ForeColor = culoare1;
            dgvTranzExped.BackgroundColor = culoare3;
            dgvTranzPrimite.BackgroundColor = culoare3;

            idContUtilizator = idCont;
        }

        private async void ActualizarePrimite()
        {
            try
            {
                DataGridView dataGridViewActualizat = new DataGridView();

                Task<DataGridView> dataGridViewUpdateTask = new Task<DataGridView>(() => dbHandler.ActualizareTranzUtilPrimite(idContUtilizator));
                dataGridViewUpdateTask.Start();
                dataGridViewActualizat = await dataGridViewUpdateTask;

                dgvTranzPrimite.DataSource = dataGridViewActualizat.DataSource;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Eroare la db: {ex}");
            }

        }

        private async void ActualizareTrimise()
        {
            try
            {
                DataGridView dataGridViewActualizat = new DataGridView();

                Task<DataGridView> dataGridViewUpdateTask = new Task<DataGridView>(() => dbHandler.ActualizareTranzUtilTrimise(idContUtilizator));
                dataGridViewUpdateTask.Start();
                dataGridViewActualizat = await dataGridViewUpdateTask;

                dgvTranzExped.DataSource = dataGridViewActualizat.DataSource;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Eroare la db: {ex}");
            }
        }

    }
}
