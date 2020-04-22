using System;
using System.Threading.Tasks;
using Tenon.Backend.Api.Repositories.Contracts;
using Tenon.Backend.Api.Services.Entities;

namespace Tenon.Backend.Api.Repositories.Implementation
{
    public class ImagesRepository : IImagesRepository
    {
        public async Task<Image> GetAsync(Guid id)
        {
            return await Task.FromResult(new Image { Id = Guid.NewGuid(), Name = "Some name" });
        }
    }
}
