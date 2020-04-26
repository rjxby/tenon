using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tenon.Backend.Api.Repositories.Implementation.DataAccessObjects;

namespace Tenon.Backend.Api.Repositories.Implementation.Configuration
{
    public class ImageConfiguration : IEntityTypeConfiguration<ImageRecord>
    {
        public void Configure(EntityTypeBuilder<ImageRecord> builder)
        {
            builder.ToTable("Images");

            builder.HasKey(p => p.Id);
            builder.HasIndex(p => p.Id).IsUnique();
            builder.Property(p => p.Id).HasDefaultValueSql("uuid_generate_v4()");

            builder.Property(p => p.Name);
        }
    }
}
