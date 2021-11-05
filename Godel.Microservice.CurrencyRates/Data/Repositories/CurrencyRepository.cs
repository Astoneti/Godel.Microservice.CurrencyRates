using Godel.Microservice.CurrencyRates.Data.Contracts;
using Godel.Microservice.CurrencyRates.Data.Entities;

namespace Godel.Microservice.CurrencyRates.Data.Repositories
{
    public class CurrencyRepository : BaseRepository<CurrencyEntity>, ICurrencyRepository
    {
        public CurrencyRepository(CurrencyDbContext dbContext) 
            : base(dbContext)
        {
        }
    }
}
