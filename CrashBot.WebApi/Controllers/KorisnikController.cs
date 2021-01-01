using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrashBot.Model;
using CrashBot.Model.Requests;
using CrashBot.WebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrashBot.WebApi.Controllers
{

    public class KorisnikController : BaseCRUDController<Model.Korisnik, Model.Requests.KorisnikSearchRequest, Model.Requests.KorisnikUpsertRequest, Model.Requests.KorisnikUpsertRequest>
    {
        public KorisnikController(ICRUDService<Korisnik, KorisnikSearchRequest, KorisnikUpsertRequest, KorisnikUpsertRequest> service) : base(service)
        {
        }
    }
}