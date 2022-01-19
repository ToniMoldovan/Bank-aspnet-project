using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity; // mostenire DbContext
using System.ComponentModel.DataAnnotations; // adnotari

namespace Banca_v5.Models
{
    public class Tranzactie
    {
        [Key]
        public int Id { get; set; }

        public int IdContExpeditor { get; set; }

        public int IdContDestinatar { get; set; }

        public double Suma { get; set; }

        public string Moneda { get; set; }

        [MaxLength(500, ErrorMessage = "Descriere prea lunga.")]
        public string Detalii { get; set; }
    }

    public class TranzactieDbContext : DbContext
    {
        public DbSet<Tranzactie> Tranzactii { get; set; }
    }
}
