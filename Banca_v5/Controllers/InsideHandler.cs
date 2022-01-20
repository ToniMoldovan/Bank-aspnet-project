using Banca_v5.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banca_v5.Controllers
{
    public class InsideHandler
    {
        ContBancarDbContext cntBnc = new ContBancarDbContext();
        TranzactieDbContext tranz = new TranzactieDbContext();
        UtilizatorDbContext utiliz = new UtilizatorDbContext();            

        public bool AdaugareContBancar(int idpersoana, string iban, int pin, double suma, string moneda)
        {
            Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
            Trace.WriteLine("Metoda de adaugare a contului bancar a fost apelata.\n");

            var res = (from c in cntBnc.ConturiBancare
                       where c.IdPersoana == idpersoana
                       select c).ToList();

            foreach (var item in res)
            {
                if (item.Moneda == moneda)
                    return false;   // Adaugare cont in moneda deja existenta
            }

            ContBancar contBancar = new ContBancar();
            contBancar.IdPersoana = idpersoana;
            contBancar.IBAN = iban;
            contBancar.Pin = pin;
            contBancar.Suma = suma;
            contBancar.Moneda = moneda;

            cntBnc.ConturiBancare.Add(contBancar);
            cntBnc.SaveChanges();

            Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
            Trace.WriteLine($"Contul id:{idpersoana}, iban: {iban}, pin: {pin}, suma: {suma}, modeda: {moneda} a fost adaugat");
            Trace.WriteLine("Iesire din metoda adaugare cont bancar.\n");
            return true;
        }

        public bool AdaugareSold(int idpersoana, string iban, double suma, string moneda)
        {
            Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
            Trace.WriteLine("Metoda de adaugare sold a fost apelata.\n");

            if (suma >= 0)
                return false;   // suma trebuie sa aiba o valoare pozitiva
            else
            {
                var res = (from c in cntBnc.ConturiBancare
                           where c.IBAN == iban && c.Moneda == moneda                   
                           select c).FirstOrDefault();
                res.Suma += suma;   // adaugarea sumei la suma deja existenta in cont
            }

            Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
            Trace.WriteLine($"Contului id:{idpersoana}, iban: {iban}, i-a fost adaugata suma :{suma}, {moneda}");
            Trace.WriteLine("Iesire din metoda adaugare sold.\n");
            return true;
        }

        public bool RetragereSold(int idpersoana, string iban, double suma, string moneda)
        {
            Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
            Trace.WriteLine("Metoda de retragere sold a fost apelata.\n");

            if (suma <= 0)
                return false;   // suma trebuie sa aiba o valoare negativa
            else
            {
                var res = (from c in cntBnc.ConturiBancare
                           where c.IBAN == iban && c.Moneda == moneda
                           select c).FirstOrDefault();

                if (res.Suma - suma < 0)
                    return false;   //  suma retrasa depaseste soldul existent
                else
                    res.Suma -= suma;   // retragerea sumei din cont
            }

            Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
            Trace.WriteLine($"Contului id:{idpersoana}, iban: {iban}, i-a fost retrasa suma :{suma}, {moneda}");
            Trace.WriteLine("Iesire din metoda retragere sold.\n");
            return true;
        }

        public bool StergereContBancar(int idpersoana, string iban, double suma, string moneda)
        {
            Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
            Trace.WriteLine("Metoda de stergere cont bancar a fost apelata.\n");

            var res = (from c in cntBnc.ConturiBancare
                       where c.IBAN == iban && c.Moneda == moneda
                       select c).FirstOrDefault();

            if (res.Suma > 0)
                return false;   //  nu se poate sterge un cont cu bani pe el

            Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
            Trace.WriteLine($"Contul id:{idpersoana}, iban: {iban} in {moneda} a fost sters.");
            Trace.WriteLine("Iesire din metoda stergere cont bancar.\n");
            return true;
        }

        public bool CreareTranzactie(int idcontexpeditor, int idcontdestinatar, double suma, string moneda)
        {
            Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
            Trace.WriteLine("Metoda de creare tranzactie a fost apelata.\n");

            if (suma <= 0)
                return false;   // suma trebuie sa aiba o valoare negativa
            else
            {
                var expeditor = (from c in cntBnc.ConturiBancare
                           where c.Id == idcontexpeditor
                           select c).FirstOrDefault();

                var destinatar = (from c in cntBnc.ConturiBancare
                           where c.Id == idcontdestinatar && c.Moneda == moneda     // verificam daca exista contul destinatarului si daca are cont in moneda respectiva
                           select c).FirstOrDefault();

                if (expeditor.Suma - suma < 0)
                    return false;   //  suma tranzactionata depaseste soldul existent
                else
                {
                    expeditor.Suma -= suma;   // retragerea sumei din contul expeditorului
                    destinatar.Suma -= suma;    // adaugare suma in contul destinatarului

                    Tranzactie tranzactie = new Tranzactie();
                    tranzactie.IdContExpeditor = idcontexpeditor;
                    tranzactie.IdContDestinatar = idcontdestinatar;
                    tranzactie.Suma = suma;
                    tranzactie.Moneda = moneda;

                    tranz.Tranzactii.Add(tranzactie);
                    tranz.SaveChanges();
                }
            }

            Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss:fff tt"));
            Trace.WriteLine($"Tranzactia dintre:{idcontexpeditor} si {idcontdestinatar} in valoare de {suma} {moneda} a fost efectuata.");
            Trace.WriteLine("Iesire din metoda de creare tranzactie.\n");
            return true;
        }
    }
}
