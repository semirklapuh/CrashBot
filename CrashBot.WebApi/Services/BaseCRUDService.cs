using AutoMapper;
using CrashBot.WebApi.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CrashBot.WebApi.Services
{
    public class BaseCRUDService<TModel, TSearch, TDatabase, TInsert, TUpdate> : BaseService<TModel, TSearch, TDatabase>, ICRUDService<TModel, TSearch, TInsert, TUpdate> where TDatabase : class
    {
        public BaseCRUDService(CrashBotContext db, IMapper mapper) : base(db, mapper)
        {
        }

        public virtual void Delete(int id)
        {
            var entity = _db.Set<TDatabase>().Find(id);
            _db.Set<TDatabase>().Remove(entity);
            _db.SaveChanges();
        }

        public virtual TModel Insert(TInsert request)
        {
            var entity = _mapper.Map<TDatabase>(request);
            _db.Set<TDatabase>().Add(entity);
            _db.SaveChanges();
            return _mapper.Map<TModel>(entity);
        }

        public virtual TModel Update(int id, TUpdate request)
        {
            var entity = _db.Set<TDatabase>().Find(id);
            _db.Set<TDatabase>().Attach(entity);
            _db.Set<TDatabase>().Update(entity);
            _mapper.Map(request, entity);


            _db.SaveChanges();
            return _mapper.Map<TModel>(entity);
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algoritam = HashAlgorithm.Create("SHA1");
            byte[] inArray = algoritam.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public TModel Authenticiraj(string username, string pass)

        {

            //try
            //{
            //    var user = _db.Korisnik.FirstOrDefault(x => x.KorisnickoIme == username);

            //    if (user != null)
            //    {
            //        var newHash = GenerateHash(user.LozinkaSalt, pass);
            //        if (newHash == user.LozinkaHash)
            //        {
            //            return _mapper.Map<TModel>(user);
            //        }
            //    }
            //}
            //catch (Exception)
            //{
            //    throw new HttpException(401, "Unauthorized access");
            //}
            return default(TModel);


        }
    }
}
