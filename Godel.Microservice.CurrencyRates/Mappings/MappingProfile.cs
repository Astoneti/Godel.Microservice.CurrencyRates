using AutoMapper;
using Godel.Microservice.CurrencyRates.Business.Dto;
using Godel.Microservice.CurrencyRates.Data.Entities;
using Godel.Microservice.CurrencyRates.Model;

namespace Godel.Microservice.CurrencyRates.MappingHelper
{
    public class CurrencyProfile : Profile
    {
        public CurrencyProfile()
        {
            CreateMap<CurrencyModel, CurrencyDto>().ReverseMap();
            CreateMap<CurrencyEntity, CurrencyDto>().ReverseMap();
        }
    }
}
