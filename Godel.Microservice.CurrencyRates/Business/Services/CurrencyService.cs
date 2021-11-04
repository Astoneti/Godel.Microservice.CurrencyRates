using AutoMapper;
using Godel.Microservice.CurrencyRates.Business.Contracts;
using Godel.Microservice.CurrencyRates.Business.Dto;
using Godel.Microservice.CurrencyRates.Data.Contracts;
using Godel.Microservice.CurrencyRates.Data.Entities;
using System.Collections.Generic;

namespace Godel.Microservice.CurrencyRates.Business.Services
{
    public class CurrencyService : ICurrencyService
    {
        public CurrencyService(ICurrencyRepository currencyRepository, IMapper mapper)
        {
            _currencyRepository = currencyRepository;
            _mapper = mapper;
        }

        private readonly ICurrencyRepository _currencyRepository;
        private readonly IMapper _mapper;

        public List<CurrencyDto> GetList()
        {
            var newList = _currencyRepository.GetList();
            return _mapper.Map<List<CurrencyEntity>, List<CurrencyDto>>(newList);
        }
    }
}
