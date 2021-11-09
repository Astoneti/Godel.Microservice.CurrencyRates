using Godel.Microservice.CurrencyRates.Data.Contracts;
using Godel.Microservice.CurrencyRates.Data.Entities;
using Godel.Microservice.CurrencyRates.Data.Repositories;

namespace Godel.Microservice.CurrencyRates.Data
{
    public class CurrencyRepository : BaseRepository<CurrencyEntity>, ICurrencyRepository
    {
        public CurrencyRepository(CurrencyDbContext dbContext) 
            : base(dbContext)
        {
        }
    }
}
