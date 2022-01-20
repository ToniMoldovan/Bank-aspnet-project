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

using System.Drawing.Text;
using Banca_v5.Models;
using System.Diagnostics;
using System.IO;

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
            File.Delete("yourlog.log");
            Trace.Listeners.Add(new TextWriterTraceListener("yourlog.log"));
            Trace.AutoFlush = true;
            Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
            Trace.WriteLine("Entering Main\n");
            
            
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
            Trace.WriteLine("Exiting Main\n");
            Trace.Unindent();
            Trace.Flush();
        }

        private void lblNuAmCont_Click(object sender, EventArgs e)
        {
            InregistrareForm inregistrareForm = new InregistrareForm();
            inregistrareForm.ShowDialog();
        }

        private void lblNuAmCont_MouseHover(object sender, EventArgs e)
        {
            lblNuAmCont.ForeColor = culoare2;
        }

        private void lblNuAmCont_MouseLeave(object sender, EventArgs e)
        {
            lblNuAmCont.ForeColor = culoare1;
        }

        private async void btnAutentificare_Click(object sender, EventArgs e)
        {
            /*Verificare input-uri*/
            if (txtBoxParola.TextLength < 3 || txtBoxUsername.TextLength < 3)
            {

                MessageBox.Show("Ai introdus prea putine caractere!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Acum se verifica datele.. Asteapta te rog.", "Rulare..", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                btnAutentificare.Enabled = false;

                string username, parola;

                username = txtBoxUsername.Text;
                parola = txtBoxParola.Text;

                Task<bool> autentificareTask = new Task<bool>(() => dbHandler.Autentificare(username, parola));
                autentificareTask.Start();
                bool rezultat = await autentificareTask;

                if (rezultat)
                {

                    Utilizator utilizator = dbHandler.GetUtilizator(username);

                    Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
                    Trace.WriteLine($"Autentificare cu succes {username}.");

                    MessageBox.Show("Autentificare cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    PrincipalForm principalForm = new PrincipalForm(utilizator.Nume, utilizator.Id);
                    principalForm.Closed += (s, args) => this.Close();
                    principalForm.ShowDialog();
                }
                else
                {
                    Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
                    Trace.WriteLine("Eroare.Numele de utilizator sau parola sunt gresite.");
                    MessageBox.Show($"Numele de utilizator {username} sau parola sunt gresite.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxParola.Clear();
                    txtBoxUsername.Clear();

                    btnAutentificare.Enabled = true;
                    Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
                    Trace.WriteLine("Iesire formular autentificare.");
                    Trace.Flush();
                }
            }
        }

        private void WelcomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
            Trace.WriteLine("Iesire form autentificare.");
            Trace.Flush();
        }
    }
}
