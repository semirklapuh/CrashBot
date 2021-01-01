using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrashBot.WebApi.Database
{
    public partial class Komanda
    {
        public int KomandaId { get; set; }
        public string Naziv { get; set; }
        public char Oznaka { get; set; }
    }
}
