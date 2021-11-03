using System.Collections.Generic;

namespace Godel.Microservice.CurrencyRates.Data.Contracts
{
    public interface IRepository<T>
    {
        public List<T> GetList();
    }
}
