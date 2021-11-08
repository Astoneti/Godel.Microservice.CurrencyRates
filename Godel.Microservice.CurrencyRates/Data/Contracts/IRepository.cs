using Godel.Microservice.CurrencyRates.Data.Entities;
using System.Collections.Generic;

namespace Godel.Microservice.CurrencyRates.Data.Contracts
{
    public interface IRepository<T>
    {
        public List<T> GetList();

        public CurrencyEntity Get(int id);

        public void Create(CurrencyEntity currency);

        public void Update(CurrencyEntity currency);

        public void Delete(int id);
    }
}
