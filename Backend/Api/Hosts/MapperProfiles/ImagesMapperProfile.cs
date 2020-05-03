using AutoMapper;
using Tenon.Backend.Api.Hosts.Models;
using Tenon.Backend.Api.Services.Entities;

namespace Tenon.Backend.Api.Hosts.MapperProfiles
{
    public class ImagesMapperProfile : Profile
    {
        public ImagesMapperProfile()
        {
            CreateMap<Image, ImageModel>().ReverseMap();
            CreateMap<CreateImageModel, Image>();
        }
    }
}
