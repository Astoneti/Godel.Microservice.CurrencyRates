using AutoMapper;
using Godel.Microservice.CurrencyRates.Business.Dto;
using Godel.Microservice.CurrencyRates.Data.Entities;
using Godel.Microservice.CurrencyRates.Model;

namespace Godel.Microservice.CurrencyRates.MappingHelper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CurrencyModel, CurrencyDto>().ReverseMap();//почему мы здесь не используем  Лист типизацию??? а работает!!!
            CreateMap<CurrencyEntity, CurrencyDto>().ReverseMap();
        }
    }
}
