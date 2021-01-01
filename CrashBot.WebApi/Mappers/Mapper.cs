using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrashBot.WebApi.Mappers
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Database.Korisnik, Model.Korisnik>();
            CreateMap<Database.ErrorLog, Model.ErrorLog>();

            CreateMap<Model.Requests.KorisnikUpsertRequest, Database.Korisnik>();
            CreateMap<Model.Requests.ErrorLogUpsertRequest, Database.ErrorLog>();
        }
    }
}
