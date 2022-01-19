using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Text;

namespace Banca_v5
{
    public partial class WelcomeForm : Form
    {
        private static Color culoare1 = Color.FromArgb(230, 57, 70);
        private static Color culoare2 = Color.FromArgb(241, 250, 238);
        private static Color culoare3 = Color.FromArgb(168, 218, 220);
        private static Color culoare4 = Color.FromArgb(69, 123, 157);
        private static Color culoare5 = Color.FromArgb(29, 53, 87);

        public WelcomeForm()
        {
            InitializeComponent();

            /*Initializare culori*/
            this.BackColor = culoare5;

            btnAutentificare.BackColor = culoare1;
            btnAutentificare.ForeColor = culoare2;
            btnAutentificare.TabStop = false;
            btnAutentificare.FlatStyle = FlatStyle.Flat;
            btnAutentificare.FlatAppearance.BorderSize = 0;

            label1.ForeColor = culoare2;
            label2.ForeColor = culoare2;
            label3.ForeColor = culoare2;
            label4.ForeColor = culoare2;

            lblNuAmCont.ForeColor = culoare1;
        }

        private void lblNuAmCont_Click(object sender, EventArgs e)
        {

        }

        private void lblNuAmCont_MouseHover(object sender, EventArgs e)
        {
            lblNuAmCont.ForeColor = culoare2;
        }

        private void lblNuAmCont_MouseLeave(object sender, EventArgs e)
        {
            lblNuAmCont.ForeColor = culoare1;
        }
    }
}
