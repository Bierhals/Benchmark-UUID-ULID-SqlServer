using Benchmark_UUID_ULID_SqlServer.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Benchmark_UUID_ULID_SqlServer.Data.Configuration
{
    internal class DataKeyUuidV7NCIBinaryDetailConfig : IEntityTypeConfiguration<DataKeyUuidV7NCIBinaryDetail>
    {
        public void Configure(EntityTypeBuilder<DataKeyUuidV7NCIBinaryDetail> builder)
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
            builder.Property(b => b.Data1)
                .IsRequired();
            builder.Property(b => b.Data2)
                .IsRequired();

            builder.HasOne<DataKeyUuidV7NCIBinary>()
                .WithMany(e => e.Details)
                .IsRequired();
        }
    }
}
