using System;
using System.Collections.Generic;
using System.Text;

namespace CrashBot.Model.Requests
{
    public class ErrorLogUpsertRequest
    {
        public int ErrorLogId { get; set; }

        public string ErrorPoruka { get; set; }

        public DateTime Datum { get; set; }

        public int KorisnikId { get; set; }
        
    }
}
