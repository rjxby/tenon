using System;
using System.Threading.Tasks;
using Tenon.Backend.Api.Services.Entities;

namespace Tenon.Backend.Api.Repositories.Contracts
{
    public interface IImagesRepository
    {
        Task<Image> GetAsync(Guid id);
    }
}
