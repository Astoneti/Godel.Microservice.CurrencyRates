using Godel.Microservice.CurrencyRates.Data.Entities;

namespace Godel.Microservice.CurrencyRates.Data.Contracts
{
    public interface ICurrencyRepository : IRepository<CurrencyEntity>
    {
    }
}
