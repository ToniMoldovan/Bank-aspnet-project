using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Banca_v5.Models
{
    public class DbHandler
    {
        ContBancarDbContext cntBnc = new ContBancarDbContext();
        TranzactieDbContext tranz = new TranzactieDbContext();
        UtilizatorDbContext utiliz = new UtilizatorDbContext();

        public bool CreareUtilizator(int idcont, string nume, string prenume, string email, string username, string parola)
        {
            Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
            Trace.WriteLine("Metoda creare utilizator a fost apelata.\n");

            string parola_hashuita = Hash.Hash_SHA1(parola);

            var res = (from u in utiliz.Utilizatori
                       where u.UserName.Equals(username)
                       select u).ToList();

            if (res.Count() > 0)
            {
                Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
                Trace.WriteLine($"Acest username: {username} este deja folosit.\n");
                return false;
            }

            Utilizator utilizator = new Utilizator();
            utilizator.IdCont = idcont;
            utilizator.Nume = nume;
            utilizator.Prenume = prenume;
            utilizator.Email = email;
            utilizator.UserName = username;
            utilizator.Parola = parola_hashuita;

            utiliz.Utilizatori.Add(utilizator);
            utiliz.SaveChanges();

            Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
            Trace.WriteLine($"Utilizatorul {username} a fost creat.\n");
            return true;
        }

        //public bool CreareContBancar(int idpersoana, string iban, int pin, double suma, string moneda)
        //{
        //    Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
        //    Trace.WriteLine("Metoda de creare a contului bancar a fost apelata\n");

        //    ContBancar contBancar = new ContBancar();
        //    contBancar.IdPersoana = idpersoana;
        //    contBancar.IBAN = iban;
        //    contBancar.Pin = pin;
        //    contBancar.Suma = suma;
        //    contBancar.Moneda = moneda;


        //    Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
        //    Trace.WriteLine($"Contul id:{idpersoana}, iban: {iban}, pin: {pin}, suma: {suma}, modeda: {moneda} a fost creat");
        //    Trace.WriteLine("Iesire din metoda creare utilizator.\n");
        //    return true;
        //}

        /*Getter implementat de Toni - in caz de bug-uri*/
        public Utilizator GetUtilizator(string username)
        {
            Utilizator utilizator = (from u in utiliz.Utilizatori
                                     where u.UserName == username
                                     select u).FirstOrDefault();

            if (utilizator != null)
            {
                return utilizator;
            }
            else
            {
                return null;
            }
        }

        //Supraincarcare functie
        public Utilizator GetUtilizator(int id)
        {
            Utilizator utilizator = (from u in utiliz.Utilizatori
                                     where u.Id == id
                                     select u).FirstOrDefault();

            if (utilizator != null)
            {
                return utilizator;
            }
            else
            {
                return null;
            }
        }

        //public bool CreareTranzactie(int idcontexpeditor, int idcontdestinatar, double suma, string moneda)
        //{
        //    Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
        //    Trace.WriteLine("Metoda creare tranzactie a fost apelata.\n");


        //    var res = (from c in cntBnc.ConturiBancare
        //               where c.IdPersoana.Equals(idcontexpeditor)
        //               select c).ToList();

        //    foreach (var item in res)
        //        if (item.Suma < suma)
        //            return false;   // suma tranzactionata ar fi mai mare decat suma din cont

        //    Tranzactie tranzactie = new Tranzactie();
        //    tranzactie.IdContExpeditor = idcontexpeditor;
        //    tranzactie.IdContDestinatar = idcontdestinatar;
        //    tranzactie.Suma = suma;
        //    tranzactie.Moneda = moneda;


        //    Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
        //    Trace.WriteLine($"Tranzactia dintre expeditorul {idcontexpeditor} si destinatarul {idcontdestinatar} cu suma de {suma} {moneda} a avut loc cu succes");
        //    Trace.WriteLine("iesiere din metoda creare tranzactie.\n");
        //    return true;
        //}

        public DataGridView ActualizareClienti()
        {
            try
            {
                var rez = (from u in utiliz.Utilizatori
                           select u);

                DataGridView dataGridView = new DataGridView();
                dataGridView.DataSource = rez.ToList();

                return dataGridView;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Eroare la db: {ex}");
            }

            return null;
        }

        public DataGridView ActualizareTranzactiiGlobale()
        {
            try
            {
                var rez = (from t in tranz.Tranzactii
                           select t);

                DataGridView dataGridView = new DataGridView();
                dataGridView.DataSource = rez.ToList();

                return dataGridView;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Eroare la db: {ex}");
            }

            return null;
        }

        public DataGridView ActualizareTranzUtilPrimite(int idCont)
        {
            try
            {
                var rez = (from t in tranz.Tranzactii
                           where t.IdContDestinatar == idCont
                           select t);

                DataGridView dataGridView = new DataGridView();
                dataGridView.DataSource = rez.ToList();

                return dataGridView;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Eroare la db: {ex}");
            }

            return null;
        }

        public DataGridView ActualizareTranzUtilTrimise(int idCont)
        {
            try
            {
                var rez = (from t in tranz.Tranzactii
                           where t.IdContExpeditor == idCont
                           select t);

                DataGridView dataGridView = new DataGridView();
                dataGridView.DataSource = rez.ToList();

                return dataGridView;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Eroare la db: {ex}");
            }

            return null;
        }

        public bool VerificareDateUtilizator(string username, string parola)
        {
            Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
            Trace.WriteLine("Metoda Verificare Date Utilizator a fost apelata.\n");

            var res = (from u in utiliz.Utilizatori
                       where u.UserName.Equals(username) && u.Parola.Equals(parola)
                       select u).ToList();

            if (res.Count() == 0)
                return false;

            return true;
        }

        public bool Autentificare(string username, string parola)
        {
            Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
            Trace.WriteLine("Metoda Autentificare a fost apelata.\n");


            string parola_hashuita = Hash.Hash_SHA1(parola);

            var res = (from u in utiliz.Utilizatori
                       where u.UserName == username && u.Parola == parola_hashuita
                       select u).FirstOrDefault();            

            if(res == null)
            {
                Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
                Trace.WriteLine($"username-ul {username} sau parola {parola} sunt gresite\n");
                return false;
            }
            else
            {
                Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
                Trace.WriteLine($"username-ul {username} si parola {parola} au fost gasite si verificate cu succes\n");
                return true;
            }            
        }
    }
}
