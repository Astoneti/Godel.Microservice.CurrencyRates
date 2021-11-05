using Godel.Microservice.CurrencyRates.Business.Dto;
using Godel.Microservice.CurrencyRates.Data.Entities;
using System.Collections.Generic;

namespace Godel.Microservice.CurrencyRates.Business.Contracts
{
    public interface ICurrencyService
    {
        public List<CurrencyDto> GetList();

        public void Create(CurrencyDto currency);
    }
}
