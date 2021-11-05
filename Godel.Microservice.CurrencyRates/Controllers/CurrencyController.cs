using AutoMapper;
using Godel.Microservice.CurrencyRates.Business.Contracts;
using Godel.Microservice.CurrencyRates.Business.Dto;
using Godel.Microservice.CurrencyRates.Data.Entities;
using Godel.Microservice.CurrencyRates.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Godel.Microservice.CurrencyRates.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrencyController : ControllerBase
    {
        private readonly ICurrencyService _currencyService;
        private readonly IMapper _mapper;

        public CurrencyController(ICurrencyService currencyService, IMapper mapper)
        {
            _currencyService = currencyService;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<CurrencyModel> Get()
        {
            var modelList = _currencyService.GetList();
            return _mapper.Map<List<CurrencyDto>, List<CurrencyModel>>(modelList);
        }

        [HttpPost]
        public void Create(CurrencyModel currency)
        {
            var currencyDto = _mapper.Map<CurrencyModel, CurrencyDto> (currency);
            _currencyService.Create(currencyDto);
        }
    }
}
