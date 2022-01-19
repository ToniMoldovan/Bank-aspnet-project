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
    public partial class InregistrareForm : Form
    {
        private static Color culoare1 = Color.FromArgb(230, 57, 70);
        private static Color culoare2 = Color.FromArgb(241, 250, 238);
        private static Color culoare3 = Color.FromArgb(168, 218, 220);
        private static Color culoare4 = Color.FromArgb(69, 123, 157);
        private static Color culoare5 = Color.FromArgb(29, 53, 87);

        public InregistrareForm()
        {
            InitializeComponent();

            /*Initializare culori*/
            this.BackColor = culoare5;

            btnInregistrare.BackColor = culoare1;
            btnInregistrare.ForeColor = culoare2;
            btnInregistrare.TabStop = false;
            btnInregistrare.FlatStyle = FlatStyle.Flat;
            btnInregistrare.FlatAppearance.BorderSize = 0;

            label1.ForeColor = culoare2;
            label2.ForeColor = culoare2;
            label3.ForeColor = culoare2;
            label4.ForeColor = culoare2;
            label5.ForeColor = culoare2;
            label6.ForeColor = culoare2;
        }

        private async void btnInregistrare_Click(object sender, EventArgs e)
        {

        }
    }
}
