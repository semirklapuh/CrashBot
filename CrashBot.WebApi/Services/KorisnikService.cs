using AutoMapper;
using CrashBot.Model.Requests;
using CrashBot.WebApi.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrashBot.WebApi.Services
{
    public class KorisnikService : BaseCRUDService<Model.Korisnik, Model.Requests.KorisnikSearchRequest, Database.Korisnik, Model.Requests.KorisnikUpsertRequest, Model.Requests.KorisnikUpsertRequest>
    {
        public KorisnikService(CrashBotContext db, IMapper mapper) : base(db, mapper)
        {
        }

        public override List<Model.Korisnik> Get(KorisnikSearchRequest search)
        {
            List<Model.Korisnik> lista = new List<Model.Korisnik>();

            var korisnik = _db.Korisnik.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.Korisnicko))
            {
                korisnik = korisnik.Where(x => x.KorisnickoIme == search.Korisnicko);
            }

            if (!string.IsNullOrWhiteSpace(search.Password))
            {
                korisnik = korisnik.Where(x => x.Lozinka == search.Password);
            }

            if (!string.IsNullOrWhiteSpace(search.Mail))
            {
                korisnik = korisnik.Where(x => x.Mail == search.Mail);
            }
            foreach (var item in korisnik)
                {
                    lista.Add(new Model.Korisnik
                    {
                        KorisnikId = item.KorisnikId,
                        Ime = item.Ime,
                        Prezime = item.Prezime,
                        KorisnickoIme = item.KorisnickoIme,
                        Telefon = item.Telefon,
                        Adresa = item.Adresa,
                        Mail = item.Mail,
                        Lozinka = item.Lozinka
                    });
                }
                return lista;
            
        }

        public override Model.Korisnik GetById(int id)
        {

            var item = _db.Korisnik.Where(w => w.KorisnikId == id)
                .SingleOrDefault();

           

            Model.Korisnik model = new Model.Korisnik
            {
                Ime = item.Ime,
                Prezime = item.Prezime,
                Adresa = item.Adresa,
                Mail = item.Mail,
                Telefon = item.Telefon,
                KorisnickoIme = item.KorisnickoIme,
                Lozinka = item.Lozinka
            };

            return model;

        }

        public override Model.Korisnik Update(int id, KorisnikUpsertRequest request)
        {
            var korisnik = _db.Korisnik.Find(id);

            korisnik.Ime = request.Ime;
            korisnik.Prezime = request.Prezime;
            korisnik.Adresa = request.Adresa;
            korisnik.KorisnickoIme = request.KorisnickoIme;
            korisnik.Lozinka = request.Lozinka;
            korisnik.Telefon = request.Telefon;
            korisnik.Mail = request.Mail;


            _db.Korisnik.Attach(korisnik);
            _db.Korisnik.Update(korisnik);

            _db.SaveChanges();

            return _mapper.Map<Model.Korisnik>(korisnik);
        }

        public override Model.Korisnik Insert(KorisnikUpsertRequest request)
        {
            Korisnik korisnik = new Korisnik();

            korisnik.Ime = request.Ime;
            korisnik.Prezime = request.Prezime;
            korisnik.Adresa = request.Adresa;
            korisnik.KorisnickoIme = request.KorisnickoIme;
            korisnik.Lozinka = request.Lozinka;
            korisnik.Telefon = request.Telefon;
            korisnik.Mail = request.Mail;
            
            _db.Korisnik.Add(korisnik);
            _db.SaveChanges();

            return _mapper.Map<Model.Korisnik>(korisnik);            
        }

    }
}

