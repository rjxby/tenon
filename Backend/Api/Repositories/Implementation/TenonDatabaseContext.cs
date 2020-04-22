using System;
using Microsoft.EntityFrameworkCore;

namespace Tenon.Backend.Api.Repositories.Implementation
{
    public class TenonDatabaseContext : DbContext
    {
        public TenonDatabaseContext(DbContextOptions<TenonDatabaseContext> options): base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
