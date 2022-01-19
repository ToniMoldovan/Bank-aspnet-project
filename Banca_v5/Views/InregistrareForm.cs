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
using Banca_v5.Views;
using System.Diagnostics;

namespace Banca_v5.Views
{
    public partial class InregistrareForm : Form
    {
        private DbHandler dbHandler = new DbHandler();

        private static Color culoare1 = Color.FromArgb(230, 57, 70);
        private static Color culoare2 = Color.FromArgb(241, 250, 238);
        private static Color culoare3 = Color.FromArgb(168, 218, 220);
        private static Color culoare4 = Color.FromArgb(69, 123, 157);
        private static Color culoare5 = Color.FromArgb(29, 53, 87);

        public InregistrareForm()
        {
            Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
            Trace.WriteLine("Initializare formular inregistrare.");

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
            /*Verificare input-uri*/
            if (txtBoxUsername.TextLength < 3 || txtBoxParola.TextLength < 3 || txtBoxNume.TextLength < 3 
                || txtBoxPrenume.TextLength < 3 || txtBoxEmail.TextLength < 3)
            {
                MessageBox.Show("Ai introdus prea putine caractere!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Acum se verifica datele.. Asteapta te rog.", "Rulare..", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                btnInregistrare.Enabled = false;

                string nume, prenume, username, parola, email;

                nume = txtBoxNume.Text;
                prenume = txtBoxPrenume.Text;
                username = txtBoxUsername.Text;
                parola = txtBoxParola.Text;
                email = txtBoxEmail.Text;

                // Apelare functie de inregistrare
                Task<bool> creareUtilizatorTask = new Task<bool>(
                    () => dbHandler.CreareUtilizator(0, nume, prenume, email, username, parola));
                creareUtilizatorTask.Start();
                bool rezultat = await creareUtilizatorTask;

                if (rezultat) //Crearea a avut loc cu succes
                {
                    MessageBox.Show("Inregistrare cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Eroare! Posibil ca utilizatorul sa existe deja.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxEmail.Clear();
                    txtBoxNume.Clear();
                    txtBoxPrenume.Clear();
                    txtBoxUsername.Clear();
                    txtBoxParola.Clear();

                    btnInregistrare.Enabled = true;
                }
            }
        }

        private void InregistrareForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
            Trace.WriteLine("Iesire formular inregistrare.");
        }
    }
}
