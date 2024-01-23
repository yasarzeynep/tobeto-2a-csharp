using AutoMapper;
using Business.Dtos.Car;
using Business.Requests.Car;
using Business.Responses.Car;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Maping.AutoMapper;

public class CarMapperProfiles : Profile
{
    public CarMapperProfiles()
    {
        CreateMap<AddCarRequest, Car>();

        CreateMap<Car, CarListItemDto>();

        CreateMap<IList<Car>, GetListCarResponse>()
            .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src));

        CreateMap<UpdateCarRequest, Car>();
        CreateMap<Car, GetCarByIdResponse>();
    }
}