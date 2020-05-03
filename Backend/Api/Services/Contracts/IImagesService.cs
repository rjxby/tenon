using System;
using System.Threading.Tasks;
using Tenon.Backend.Api.Services.Entities;

namespace Tenon.Backend.Api.Services.Contracts
{
    public interface IImagesService
    {
        Task<Image> GetAsync(Guid id);

        Task<Image> CreateAsync(Image image);
    }
}
