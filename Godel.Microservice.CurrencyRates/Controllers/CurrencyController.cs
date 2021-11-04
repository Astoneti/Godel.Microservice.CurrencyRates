using AutoMapper;
using Godel.Microservice.CurrencyRates.Business.Contracts;
using Godel.Microservice.CurrencyRates.Business.Dto;
using Godel.Microservice.CurrencyRates.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Godel.Microservice.CurrencyRates.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrencyController : ControllerBase
    {
        public CurrencyController(ILogger<CurrencyController> logger, ICurrencyService currencyService, IMapper mapper)
        {
            _logger = logger;
            _currencyService = currencyService;
            _mapper = mapper;
        }

        private readonly ILogger<CurrencyController> _logger; //Will be needed in further development!
        private readonly ICurrencyService _currencyService;
        private readonly IMapper _mapper;

        [HttpGet]
        public IEnumerable<CurrencyModel> Get()
        {
            var newList = _currencyService.GetList();
            return _mapper.Map<List<CurrencyDto>, List<CurrencyModel>>(newList);
        }
    }
}
