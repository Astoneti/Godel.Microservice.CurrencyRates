using Godel.Microservice.CurrencyRates.Business.Dto;
using System.Collections.Generic;

namespace Godel.Microservice.CurrencyRates.Business.Contracts
{
    public interface ICurrencyService
    {
        public List<CurrencyDto> GetList();
    }
}
