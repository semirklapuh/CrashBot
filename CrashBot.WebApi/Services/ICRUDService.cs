using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrashBot.WebApi.Services
{
    public interface ICRUDService<T, TSearch, TInsert, TUpdate> : IService<T, TSearch>
    {
        T Insert(TInsert request);

        T Update(int id, TUpdate request);

        void Delete(int id);
        T Authenticiraj(string username, string pass);


    }
}
