using System;
using System.Collections.Generic;
using System.Text;

namespace CrashBot.Model.Requests
{
    public class ErrorLogSearchRequest
    {
        public string ErrorPoruka { get; set; }

        public DateTime Datum { get; set; }

        public int KorisnikId { get; set; }

        public DateTime datumOd { get; set; }
        public DateTime datumDo { get; set; }
    }
}
