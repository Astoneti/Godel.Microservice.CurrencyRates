using Godel.Microservice.CurrencyRates.Data.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Godel.Microservice.CurrencyRates.Data.Repositories
{
    public class BaseRepository<T> : IRepository<T>
        where T : class
    {
        public BaseRepository(DbContext dbContext)
        {
            DbContext = dbContext;
        }

        protected DbContext DbContext { get; }

        public List<T> GetList()
        {
            return DbContext.Set<T>().ToList();
        }
    }
}
