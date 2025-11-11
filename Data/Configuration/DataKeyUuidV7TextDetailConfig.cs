using Benchmark_UUID_ULID_SqlServer.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace Benchmark_UUID_ULID_SqlServer.Data.Configuration
{
    internal class DataKeyUuidV7TextDetailConfig : IEntityTypeConfiguration<DataKeyUuidV7TextDetail>
    {
        public void Configure(EntityTypeBuilder<DataKeyUuidV7TextDetail> builder)
        {
            builder
                .HasKey(b => b.Id);
            //clustered index is default
            //.IsClustered(true);


            builder.Property(b => b.Id)
                .HasColumnType("char(36)")
                .HasConversion(
                    v => v.ToString(),
                    v => new Guid(v))
                .IsRequired()
                .ValueGeneratedNever();
            builder.Property(b => b.Data1)
                .IsRequired();
            builder.Property(b => b.Data2)
                .IsRequired();

            builder.HasOne<DataKeyUuidV7Text>()
                .WithMany(e => e.Details)
                .IsRequired();
        }
    }
}
