using AutoMapper;
using CarRent.CarManagement.Api;
using CarRent.CarManagement.Domain;

namespace CarRent.Common.Infrastructure.Mapper
{
    public class CarMapper : Profile
    {
        public CarMapper()
        {
            CreateMap<CarDto, Car>()
                .ForMember(dest => dest.carClass, opt => opt.Ignore());
            CreateMap<Car, CarDto>()
                .ForMember(dest => dest.carClass, opt => opt.MapFrom(src => src.carClass.carClassType))
                .ForMember(dest => dest.carPriceDay, opt => opt.MapFrom(src => src.carClass.dailyFee));
            CreateMap<ClassDto, Class>();
            CreateMap<Class, ClassDto>();
        }
    }
}
