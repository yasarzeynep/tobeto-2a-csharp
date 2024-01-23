using AutoMapper;
using Business.Dtos.Model;
using Business.Requests.Model;
using Business.Responses.Model;
using Entities.Concrete;

namespace Business.Profiles.Maping.AutoMapper;

public class ModelMapperProfiles:Profile
{
    public ModelMapperProfiles()
    {
        CreateMap<AddModelRequest, Model>();

        CreateMap<Model, ModelListItemDto>();
        CreateMap<IList<Model>, GetListModelResponse>()
             .ForMember( dest => dest.Items, opt => opt.MapFrom( src => src));

        CreateMap<UpdateModelRequest, Model>();
        CreateMap<Model, GetModelByIdRequests>();



    }
}
