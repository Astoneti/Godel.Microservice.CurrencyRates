using AutoMapper;
using Godel.Microservice.CurrencyRates.Business.Contracts;
using Godel.Microservice.CurrencyRates.Business.Dto;
using Godel.Microservice.CurrencyRates.Data.Contracts;
using Godel.Microservice.CurrencyRates.Data.Entities;
using System.Collections.Generic;

namespace Godel.Microservice.CurrencyRates.Business
{
    public class CurrencyService : ICurrencyService
    {
        private readonly ICurrencyRepository _currencyRepository;
        private readonly IMapper _mapper;

        public CurrencyService(ICurrencyRepository currencyRepository, IMapper mapper)
        {
            _currencyRepository = currencyRepository;
            _mapper = mapper;
        }

        public List<CurrencyDto> GetList()
        {
            var newList = _currencyRepository.GetList();
            return _mapper.Map<List<CurrencyEntity>, List<CurrencyDto>>(newList);
        }

        public CurrencyDto Get(int id) 
        {
            var currencyId = _currencyRepository.Get(id);
            return _mapper.Map<CurrencyEntity, CurrencyDto>(currencyId);
        }

        public void Create(CurrencyDto currencyDto)
        {
            var currency = _mapper.Map<CurrencyDto, CurrencyEntity>(currencyDto);
            _currencyRepository.Create(currency);
        }

        public void Update(CurrencyDto currencyDto)
        {
            var currency = _mapper.Map<CurrencyDto, CurrencyEntity>(currencyDto);
            _currencyRepository.Update(currency);
        }

        public void Delete(CurrencyDto currencyDto)
        {
            var currency = _mapper.Map<CurrencyDto, CurrencyEntity>(currencyDto);
            _currencyRepository.Delete(currency);
        }
    }
}
