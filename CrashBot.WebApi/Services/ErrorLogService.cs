using AutoMapper;
using CrashBot.Model.Requests;
using CrashBot.WebApi.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrashBot.WebApi.Services
{
    public class ErrorLogService : BaseCRUDService<Model.ErrorLog, Model.Requests.ErrorLogSearchRequest, Database.ErrorLog, Model.Requests.ErrorLogUpsertRequest, Model.Requests.ErrorLogUpsertRequest>
    {
        public ErrorLogService(CrashBotContext db, IMapper mapper) : base(db, mapper)
        {
        }

        public override List<Model.ErrorLog> Get(ErrorLogSearchRequest search)
        {
            List<Model.ErrorLog> lista = new List<Model.ErrorLog>();

            var error = _db.ErrorLog.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.ErrorPoruka))
            {
                error = error.Where(x => x.ErrorPoruka == search.ErrorPoruka);
            }

            if (search.KorisnikId!=0)
            {
                error = error.Where(x => x.KorisnikId == search.KorisnikId);
            }

            if (search.datumOd != search.datumDo)
            {
                if (search.datumDo != null && search.datumOd != null)
                {
                    error = error.Where(x => x.Datum >= search.datumOd && x.Datum <= search.datumDo);
                }
            }

            foreach (var item in error)
            {
                lista.Add(new Model.ErrorLog
                {
                    ErrorLogId = item.ErrorLogId,
                    ErrorPoruka = item.ErrorPoruka,
                    Datum = item.Datum,
                    KorisnikId = item.KorisnikId,
                   // Korisnik = item.Korisnik.KorisnickoIme
                });
            }
            return lista;

        }

        public override Model.ErrorLog Insert(ErrorLogUpsertRequest request)
        {
            ErrorLog error = new ErrorLog();

            error.ErrorPoruka = request.ErrorPoruka;
            error.Datum = request.Datum;
            error.KorisnikId = request.KorisnikId;

            _db.ErrorLog.Add(error);
            _db.SaveChanges();

            return _mapper.Map<Model.ErrorLog>(error);
        }
    }
}
