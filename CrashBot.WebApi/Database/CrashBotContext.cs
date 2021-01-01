using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrashBot.WebApi.Database
{
    public partial class CrashBotContext : DbContext
    {

        public CrashBotContext()
        {

        }

        public CrashBotContext(DbContextOptions<CrashBotContext> options)
           : base(options)
        {
        }
        public virtual DbSet<Komanda> Komanda { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }

        public virtual DbSet<ErrorLog> ErrorLog { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=CrashBot;Trusted_Connection=True;");
            }
        }
    }
}
