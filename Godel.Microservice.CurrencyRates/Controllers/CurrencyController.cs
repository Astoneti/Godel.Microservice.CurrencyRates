using AutoMapper;
using Godel.Microservice.CurrencyRates.Business.Contracts;
using Godel.Microservice.CurrencyRates.Business.Dto;
using Godel.Microservice.CurrencyRates.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Godel.Microservice.CurrencyRates.Controllers
{
    [ApiController]
    [Route("currencies")]
    public class CurrencyController : ControllerBase
    {
        private readonly ICurrencyService _currencyService;
        private readonly IMapper _mapper;

        public CurrencyController(ICurrencyService currencyService, IMapper mapper)
        {
            _currencyService = currencyService;
            _mapper = mapper;
        }

        [HttpGet("list")]
        public IEnumerable<CurrencyModel> Get()
        {
            var modelList = _currencyService.GetList();
            return _mapper.Map<List<CurrencyDto>, List<CurrencyModel>>(modelList);
        }

        [HttpGet("{id}")]
        public CurrencyModel Get(int id)
        {
            var currencyId = _currencyService.Get(id);
            return _mapper.Map<CurrencyDto, CurrencyModel>(currencyId);
        }

        [HttpPost("create")]
        public void Create(CurrencyModel currency)
        {
            var currencyDto = _mapper.Map<CurrencyModel, CurrencyDto>(currency);
            _currencyService.Create(currencyDto);
        }

        [HttpPut("edit")]
        public void Edit(CurrencyModel currency)
        {
            var currencyDto = _mapper.Map<CurrencyModel, CurrencyDto>(currency);
            _currencyService.Update(currencyDto);
        }

        [HttpDelete("delete")]
        public void Delete(int id)
        {
            var currencyDto = _currencyService.Get(id);
            _mapper.Map<CurrencyDto, CurrencyModel>(currencyDto);
            _currencyService.Delete(currencyDto);
        }
    }
}
