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
    public partial class AdaugContBancForm : Form
    {
        private DbHandler dbHandler = new DbHandler();

        private static Color culoare1 = Color.FromArgb(230, 57, 70);
        private static Color culoare2 = Color.FromArgb(241, 250, 238);
        private static Color culoare3 = Color.FromArgb(168, 218, 220);
        private static Color culoare4 = Color.FromArgb(69, 123, 157);
        private static Color culoare5 = Color.FromArgb(29, 53, 87);

        public AdaugContBancForm()
        {
            InitializeComponent();

            /*Initializare culori*/
            this.BackColor = culoare5;

            btnAdaugareCont.BackColor = culoare1;
            btnAdaugareCont.ForeColor = culoare2;
            btnAdaugareCont.TabStop = false;
            btnAdaugareCont.FlatStyle = FlatStyle.Flat;
            btnAdaugareCont.FlatAppearance.BorderSize = 0;

            label1.ForeColor = culoare2;
            label2.ForeColor = culoare2;
            label3.ForeColor = culoare2;
            label5.ForeColor = culoare2;
            label6.ForeColor = culoare2;
        }

        private async void btnAdaugareCont_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se proceseaza... Asteapta te rog.", "Rulare..", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int pin = 0;
            double suma = 0.0;
            string iban = "", moneda = "";

            //verificare text-box-uri
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBoxIBAN.Text, "[^0-9]") || System.Text.RegularExpressions.Regex.IsMatch(txtBoxPIN.Text, "[^0-9]") || System.Text.RegularExpressions.Regex.IsMatch(txtBoxSuma.Text, "[^0-9]"))
            {
                MessageBox.Show("Introdu doar numere!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxIBAN.Clear();
                txtBoxPIN.Clear();
                txtBoxSuma.Clear();
            }
            else
            {
                if (txtBoxPIN.TextLength != 4 || txtBoxSuma.TextLength < 2)
                {
                    MessageBox.Show("Lungimea pin-ului trebuie sa fie de 4 caractere sau suma introdusa este prea mica (minim 2 cifre)", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxPIN.Clear();
                    txtBoxSuma.Clear();
                }
                else
                {
                    pin = int.Parse(txtBoxPIN.Text);
                    suma = double.Parse(txtBoxSuma.Text);

                    if (txtBoxIBAN.TextLength != 10) //Aici setez ca marimea pentru IBAN sa fie strict de 10 caractere
                    {
                        MessageBox.Show("IBAN-ul trebuie sa fie de 10 caractere", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtBoxIBAN.Clear();
                    }
                    else
                    {
                        iban = txtBoxIBAN.Text;

                        if (txtBoxMoneda.Text != "EURO" || txtBoxMoneda.Text != "RON")
                        {
                            MessageBox.Show("Moneda introdusa gresit.\n\nIntrodu EURO sau RON", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtBoxMoneda.Clear();
                        }
                        else
                        {
                            moneda = txtBoxMoneda.Text;

                            //Apelare functie creare cont bancar
                        }
                    }
                }
            }
        }
    }
}
