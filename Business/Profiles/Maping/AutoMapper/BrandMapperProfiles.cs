using AutoMapper;
using Business.Dtos.Brand;
using Business.Requests.Brand;
using Business.Responses.Brand;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Maping.AutoMapper
{
    public class BrandMapperProfiles : Profile
    {
        public BrandMapperProfiles()
        {
            CreateMap<AddBrandRequest, Brand>();
            CreateMap<Brand, AddBrandResponse>();
            CreateMap<Brand, BrandListItemDto>();
            CreateMap<IList<Brand>, GetBrandListResponse>()
                .ForMember(
                    destinationMember: dest => dest.Items,
                    memberOptions: opt => opt.MapFrom(mapExpression: src => src)
                );
        }

    }
}
