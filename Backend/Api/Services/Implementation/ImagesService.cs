using System;
using System.Threading.Tasks;
using Tenon.Backend.Api.Repositories.Contracts;
using Tenon.Backend.Api.Services.Contracts;
using Tenon.Backend.Api.Services.Entities;

namespace Tenon.Backend.Api.Services.Implementation
{
    public class ImagesService : IImagesService
    {
        private readonly IImagesRepository _imagesRepository;

        public ImagesService(IImagesRepository imagesRepository)
        {
            _imagesRepository = imagesRepository;
        }

        public async Task<Image> GetAsync(Guid id)
        {
            return await _imagesRepository.GetAsync(id);
        }
    }
}
