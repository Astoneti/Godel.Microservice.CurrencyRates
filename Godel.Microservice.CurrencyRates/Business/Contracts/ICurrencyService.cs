using Godel.Microservice.CurrencyRates.Business.Dto;
using System.Collections.Generic;

namespace Godel.Microservice.CurrencyRates.Business.Contracts
{
    public interface ICurrencyService
    {
        public List<CurrencyDto> GetList();

        public CurrencyDto Get(int id);

        public void Create(CurrencyDto currency);

        public void Update(CurrencyDto currency);

        public void Delete(CurrencyDto currency);
    }
}
