using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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
            Trace.WriteLine("Metoda creare utilizator a fost apelata.");

            string parola_hashuita = Hash.Hash_SHA1(parola);

            var res = (from u in utiliz.Utilizatori
                       where u.UserName.Equals(username)
                       select u).ToList();

            if (res.Count() > 0)
            {
                Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
                Trace.WriteLine("Acest username este deja folosit.");
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
            Trace.WriteLine("Utilizatorul a fost creat.");
            return true;
        }

        public bool CreareContBancar(int idpersoana, string iban, int pin, double suma, string moneda)
        {
            ContBancar contBancar = new ContBancar();
            contBancar.IdPersoana = idpersoana;
            contBancar.IBAN = iban;
            contBancar.Pin = pin;
            contBancar.Suma = suma;
            contBancar.Moneda = moneda;

            return true;
        }

        public bool CreareTranzactie(int idcontexpeditor, int idcontdestinatar, double suma, string moneda)
        {            
            var res = (from c in cntBnc.ConturiBancare
                       where c.IdPersoana.Equals(idcontexpeditor)
                       select c).ToList();

            foreach (var item in res)
                if (item.Suma < suma)
                    return false;   // suma tranzactionata ar fi mai mare decat suma din cont

            Tranzactie tranzactie = new Tranzactie();
            tranzactie.IdContExpeditor = idcontexpeditor;
            tranzactie.IdContDestinatar = idcontdestinatar;
            tranzactie.Suma = suma;
            tranzactie.Moneda = moneda;

            return true;
        }

        public bool VerificareDateUtilizator(string username, string parola)
        {
            var res = (from u in utiliz.Utilizatori
                       where u.UserName.Equals(username) && u.Parola.Equals(parola)
                       select u).ToList();

            if (res.Count() == 0)
                return false;

            return true;
        }

        public bool Autentificare(string username, string parola)
        {
            string parola_hashuita = Hash.Hash_SHA1(parola);

            var res = (from u in utiliz.Utilizatori
                       where u.UserName == username && u.Parola == parola_hashuita
                       select u).FirstOrDefault();            

            if(res == null)
            {
                Console.WriteLine("username-ul sau parola nu au fost gresite(din functia care verifica parola si username-ul)");
                return false;
            }
            else
            {
                Console.WriteLine("username-ul si parola au fost gasite si verificate cu succes");
                return true;
            }            
        }
    }
}
