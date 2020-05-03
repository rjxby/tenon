using AutoMapper;
using Tenon.Backend.Api.Repositories.Implementation.DataAccessObjects;
using Tenon.Backend.Api.Services.Entities;

namespace Tenon.Backend.Api.Repositories.Implementation.MapperProfiles
{
    public class ImagesMapperProfile : Profile
    {
        public ImagesMapperProfile()
        {
            CreateMap<Image, ImageRecord>().ReverseMap();
        }
    }
}
