using System;
using System.Collections.Generic;
using System.Text;

namespace CrashBot.Model
{
   public class ErrorLog
    {
        public int ErrorLogId { get; set; }

        public string ErrorPoruka { get; set; }

        public DateTime Datum { get; set; }

        public int KorisnikId { get; set; }
       // public string Korisnik { get; set; }
    }
}
