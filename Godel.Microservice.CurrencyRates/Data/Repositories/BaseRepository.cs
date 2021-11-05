using Godel.Microservice.CurrencyRates.Data.Contracts;
using Godel.Microservice.CurrencyRates.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Godel.Microservice.CurrencyRates.Data.Repositories
{
    public class BaseRepository<T> : IRepository<T>
        where T : class
    {
        protected DbContext DbContext { get; }

        public BaseRepository(DbContext dbContext)
        {
            DbContext = dbContext;
        }

        public List<T> GetList()
        {
            return DbContext.Set<T>().ToList();
        }

        public void Create(CurrencyEntity currency) 
        {
            DbContext.Add(currency);
            DbContext.SaveChanges();
        }
    }
}
