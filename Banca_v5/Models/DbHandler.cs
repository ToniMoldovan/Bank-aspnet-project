using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca_v5.Models
{
    public class DbHandler
    {
        ContBancarDbContext cntBnc = new ContBancarDbContext();
        TranzactieDbContext tranz = new TranzactieDbContext();
        UtilizatorDbContext utiliz = new UtilizatorDbContext();

        public bool CreareUtilizator(int idcont, string nume, string prenume, string email, string username, string parola)
        {
            var res = (from u in utiliz.Utilizatori
                       where u.UserName.Equals(username)
                       select u).ToList();

            if (res.Count() > 0)
                return false;

            Utilizator utilizator = new Utilizator();
            utilizator.IdCont = idcont;
            utilizator.Nume = nume;
            utilizator.Prenume = prenume;
            utilizator.Email = email;
            utilizator.UserName = username;
            utilizator.Parola = parola;

            utiliz.Utilizatori.Add(utilizator);
            utiliz.SaveChanges();

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
    }
}
