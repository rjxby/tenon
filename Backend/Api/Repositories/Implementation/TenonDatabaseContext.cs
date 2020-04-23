using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Tenon.Backend.Api.Repositories.Implementation.DataAccessObjects;

namespace Tenon.Backend.Api.Repositories.Implementation
{
    public class TenonDatabaseContext : DbContext
    {
        public TenonDatabaseContext(DbContextOptions<TenonDatabaseContext> options): base(options) { }

        public virtual DbSet<ImageRecord> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
