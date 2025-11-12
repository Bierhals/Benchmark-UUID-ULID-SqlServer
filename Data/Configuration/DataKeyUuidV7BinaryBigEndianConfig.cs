using Benchmark_UUID_ULID_SqlServer.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Benchmark_UUID_ULID_SqlServer.Data.Configuration
{
    internal class DataKeyUuidV7BinaryBigEndianConfig : IEntityTypeConfiguration<DataKeyUuidV7BinaryBigEndian>
    {
        public void Configure(EntityTypeBuilder<DataKeyUuidV7BinaryBigEndian> builder)
        {
            builder
                .HasKey(b => b.Id);
            //clustered index is default
            //.IsClustered(true);

            builder.Property(b => b.Id)
                .HasColumnType("binary(16)")
                .HasConversion(
                    v => v.ToByteArray(true),
                    v => new Guid(v, true))
                .IsRequired()
                .ValueGeneratedNever();
            builder.Property(b => b.Counter)
                .IsRequired();

            builder.HasMany(b => b.Details);
        }
    }
}
