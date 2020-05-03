using System;
using System.Threading.Tasks;

namespace Tenon.Backend.Api.Repositories.Implementation
{
    public abstract class BaseRepository
    {
        internal readonly TenonDatabaseContext _context;

        public BaseRepository(TenonDatabaseContext context)
        {
            _context = context;
        }

        protected async Task<T> CommitAsync<T>(Func<Task<T>> func)
        {
            var result = await func();

            await _context.SaveChangesAsync();

            return result;
        }
    }
}
