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
using Banca_v5.Models;
using System.Diagnostics;

namespace Banca_v5
{
    public partial class WelcomeForm : Form
    {
        DbHandler dbHandler = new DbHandler();

        private static Color culoare1 = Color.FromArgb(230, 57, 70);
        private static Color culoare2 = Color.FromArgb(241, 250, 238);
        private static Color culoare3 = Color.FromArgb(168, 218, 220);
        private static Color culoare4 = Color.FromArgb(69, 123, 157);
        private static Color culoare5 = Color.FromArgb(29, 53, 87);

        public WelcomeForm()
        {
            Trace.Listeners.Add(new TextWriterTraceListener("yourlog.log"));
            Trace.AutoFlush = true;
            Trace.Indent();
            Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
            Trace.WriteLine("Entering Main");
            
            
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

            Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
            Trace.WriteLine("Exiting Main");
            Trace.Unindent();
            Trace.Flush();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAutentificare_Click(object sender, EventArgs e)
        {
            
        }
    }
}
