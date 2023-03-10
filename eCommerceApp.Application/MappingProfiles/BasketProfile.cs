using AutoMapper;
using eCommerceApp.Application.Features.Basket.Queries.GetBasketPage;

namespace eCommerceApp.Application.MappingProfiles
{
    public class BasketProfile : Profile
    {
        public BasketProfile()
        {
            CreateMap<Domain.Basket, BasketDto>();
        }
    }
}