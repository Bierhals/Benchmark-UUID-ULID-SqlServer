using Benchmark_UUID_ULID_SqlServer.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Benchmark_UUID_ULID_SqlServer.Data.Configuration
{
    internal class DataKeyUlidBinaryConfig : IEntityTypeConfiguration<DataKeyUlidBinary>
    {
        public void Configure(EntityTypeBuilder<DataKeyUlidBinary> builder)
        {
            builder
                .HasKey(b => b.Id);
            //clustered index is default
            //.IsClustered(true);

            builder.Property(b => b.Id)
                .HasColumnType("binary(16)")
                .HasConversion(
                    v => v.ToByteArray(),
                    v => Ulid.Parse(v))
                .IsRequired()
                .ValueGeneratedNever();
            builder.Property(b => b.Counter)
                .IsRequired();

            builder.HasMany(b => b.Details);
        }
    }
}
