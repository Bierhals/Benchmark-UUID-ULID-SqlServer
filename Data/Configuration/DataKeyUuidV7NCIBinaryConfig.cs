using Benchmark_UUID_ULID_SqlServer.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Benchmark_UUID_ULID_SqlServer.Data.Configuration
{
    internal class DataKeyUuidV7NCIBinaryConfig : IEntityTypeConfiguration<DataKeyUuidV7NCIBinary>
    {
        public void Configure(EntityTypeBuilder<DataKeyUuidV7NCIBinary> builder)
        {
            builder
                .HasKey(b => b.Id)
                .IsClustered(false);

            builder.Property(b => b.Id)
                .HasColumnType("binary(16)")
                .HasConversion(
                    v => v.ToByteArray(),
                    v => new Guid(v))
                .IsRequired()
                .ValueGeneratedNever();
            builder.Property(b => b.Counter)
                .IsRequired();

            builder.HasMany(b => b.Details);
        }
    }
}
