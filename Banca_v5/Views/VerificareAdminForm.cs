using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banca_v5.Views
{
    public partial class VerificareAdminForm : Form
    {
        private static Color culoare1 = Color.FromArgb(230, 57, 70);
        private static Color culoare2 = Color.FromArgb(241, 250, 238);
        private static Color culoare3 = Color.FromArgb(168, 218, 220);
        private static Color culoare4 = Color.FromArgb(69, 123, 157);
        private static Color culoare5 = Color.FromArgb(29, 53, 87);

        public VerificareAdminForm()
        {
            InitializeComponent();

            label3.ForeColor = culoare2;
            this.BackColor = culoare5;

            btnAutentificare.BackColor = culoare1;
            btnAutentificare.ForeColor = culoare2;
            btnAutentificare.TabStop = false;
            btnAutentificare.FlatStyle = FlatStyle.Flat;
            btnAutentificare.FlatAppearance.BorderSize = 0;
        }

        private void btnAutentificare_Click(object sender, EventArgs e)
        {
            btnAutentificare.Enabled = false;
            //De aici se poate schimba parola "secreta" :))
            if (txtBoxParolaAdmin.Text == "12345")
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Parola gresita.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxParolaAdmin.Clear();
                btnAutentificare.Enabled = true;
            }
        }
    }
}
