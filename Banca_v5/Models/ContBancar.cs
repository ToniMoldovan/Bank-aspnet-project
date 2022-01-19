using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity; // mostenire DbContext
using System.ComponentModel.DataAnnotations; // adnotari

namespace Banca_v5.Models
{
    public class ContBancar
    {
        [Key]
        public int Id { get; set; }

        public int IdPersoana { get; set; }

        public string IBAN { get; set; }

        public int Pin { get; set; }

        public double Suma { get; set; }

        public string Moneda { get; set; }
    }

    public class ContBancarDbContext : DbContext
    {
        public DbSet<ContBancar> ConturiBancare { get; set; }
    }
}
