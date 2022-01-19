using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity; // mostenire DbContext
using System.ComponentModel.DataAnnotations; // adnotari

namespace Banca_v5
{
    public class Utilizator
    {
        [Key]
        public int Id { get; set; }

        public int IdCont { get; set; }

        public string Nume { get; set; }

        public string Prenume { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public string Parola { get; set; }        
    }

    public class UtilizatorDbContext : DbContext
    {
        public DbSet<Utilizator> Utilizatori { get; set; }
    }
}
