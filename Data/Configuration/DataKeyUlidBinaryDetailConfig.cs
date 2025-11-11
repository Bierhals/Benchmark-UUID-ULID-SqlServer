using Benchmark_UUID_ULID_SqlServer.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Benchmark_UUID_ULID_SqlServer.Data.Configuration
{
    internal class DataKeyUlidBinaryDetailConfig : IEntityTypeConfiguration<DataKeyUlidBinaryDetail>
    {
        public void Configure(EntityTypeBuilder<DataKeyUlidBinaryDetail> builder)
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
            builder.Property(b => b.Data1)
                .IsRequired();
            builder.Property(b => b.Data2)
                .IsRequired();

            builder.HasOne<DataKeyUlidBinary>()
                .WithMany(e => e.Details)
                .IsRequired();
        }
    }
}
