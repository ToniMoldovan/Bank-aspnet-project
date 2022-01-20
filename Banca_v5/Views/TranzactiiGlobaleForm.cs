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
    public partial class TranzactiiGlobaleForm : Form
    {
        private DbHandler dbHandler = new DbHandler();

        private static Color culoare1 = Color.FromArgb(230, 57, 70);
        private static Color culoare2 = Color.FromArgb(241, 250, 238);
        private static Color culoare3 = Color.FromArgb(168, 218, 220);
        private static Color culoare4 = Color.FromArgb(69, 123, 157);
        private static Color culoare5 = Color.FromArgb(29, 53, 87);

        public TranzactiiGlobaleForm()
        {
            InitializeComponent();
            Actualizare();

            this.BackColor = culoare5;
            this.ForeColor = culoare2;
        }

        private async void Actualizare()
        {
            DataGridView dataGridViewActualizat = new DataGridView();

            Task<DataGridView> dataGridViewUpdateTask = new Task<DataGridView>(() => dbHandler.ActualizareTranzactiiGlobale());
            dataGridViewUpdateTask.Start();
            dataGridViewActualizat = await dataGridViewUpdateTask;

            dgvTranzactii.DataSource = dataGridViewActualizat.DataSource;
        }
    }
}
