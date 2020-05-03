using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Tenon.Backend.Api.Repositories.Contracts;
using Tenon.Backend.Api.Repositories.Implementation.DataAccessObjects;
using Tenon.Backend.Api.Services.Entities;

namespace Tenon.Backend.Api.Repositories.Implementation
{
    public class ImagesRepository : BaseRepository, IImagesRepository
    {
        private readonly IMapper _mapper;

        public ImagesRepository(TenonDatabaseContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public async Task<Image> GetAsync(Guid id)
        {
            var record = await _context.Images.FirstOrDefaultAsync(i => i.Id.Equals(id));
            return _mapper.Map<Image>(record);
        }

        public async Task<Image> CreateAsync(Image image)
        {
            var record = _mapper.Map<ImageRecord>(image);
            var entityEntry = await CommitAsync(async () => await _context.Images.AddAsync(record));
            return _mapper.Map<Image>(entityEntry.Entity);
        }
    }
}
