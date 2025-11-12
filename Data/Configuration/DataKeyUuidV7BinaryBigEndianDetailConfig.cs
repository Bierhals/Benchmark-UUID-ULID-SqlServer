using Benchmark_UUID_ULID_SqlServer.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Benchmark_UUID_ULID_SqlServer.Data.Configuration
{
    internal class DataKeyUuidV7BinaryBigEndianDetailConfig : IEntityTypeConfiguration<DataKeyUuidV7BinaryBigEndianDetail>
    {
        public void Configure(EntityTypeBuilder<DataKeyUuidV7BinaryBigEndianDetail> builder)
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
            builder.Property(b => b.Data1)
                .IsRequired();
            builder.Property(b => b.Data2)
                .IsRequired();

            builder.HasOne<DataKeyUuidV7BinaryBigEndian>()
                .WithMany(e => e.Details)
                .IsRequired();
        }
    }
}
