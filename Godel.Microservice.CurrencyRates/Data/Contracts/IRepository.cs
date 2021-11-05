using Godel.Microservice.CurrencyRates.Data.Entities;
using System.Collections.Generic;

namespace Godel.Microservice.CurrencyRates.Data.Contracts
{
    public interface IRepository<T>
    {
        public List<T> GetList();

        public void Create(CurrencyEntity currency);
    }
}
