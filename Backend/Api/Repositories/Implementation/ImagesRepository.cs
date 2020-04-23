using System;
using System.Threading.Tasks;
using Tenon.Backend.Api.Repositories.Contracts;
using Tenon.Backend.Api.Services.Entities;

namespace Tenon.Backend.Api.Repositories.Implementation
{
    public class ImagesRepository : BaseRepository, IImagesRepository
    {
        public ImagesRepository(TenonDatabaseContext context) : base(context)
        {
        }

        public async Task<Image> GetAsync(Guid id)
        {
            return await Task.FromResult(new Image { Id = Guid.NewGuid(), Name = "Some name" });
        }

        public async Task<Image> CreateAsync(Image image)
        {
            return await CommitAsync(() => Task.FromResult(new Image { Id = Guid.NewGuid(), Name = image.Name }));
        }
    }
}
