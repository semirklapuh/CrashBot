using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrashBot.WebApi.Database
{
    public partial class ErrorLog
    {
        public int ErrorLogId { get; set; }

        public string ErrorPoruka { get; set; }

        public DateTime Datum { get; set; }

        public int KorisnikId { get; set; }
        public virtual Korisnik Korisnik { get; set; }
    }
}
