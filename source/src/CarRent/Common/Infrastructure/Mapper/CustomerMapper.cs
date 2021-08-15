using AutoMapper;
using CarRent.CustomerManagement.Api;
using CarRent.CustomerManagement.Domain;

namespace CarRent.Common.Infrastructure.Mapper
{
    public class CustomerMapper : Profile
    {
        public CustomerMapper()
        {
            CreateMap<Customer, CustomerDto>()
                .ForMember(dest => dest.plz, opt => opt.MapFrom(src => src.plz.plz))
                .ForMember(dest => dest.country, opt => opt.MapFrom(src => src.plz.country))
                .ForMember(dest => dest.city, opt => opt.MapFrom(src => src.plz.city));

            CreateMap<CustomerDto, Customer>()
                .ForMember(dest => dest.plz, opt => opt.Ignore());

            CreateMap<Plz, PlzCodeDto>();
            CreateMap<PlzCodeDto, Plz>();
        }
    }
}
