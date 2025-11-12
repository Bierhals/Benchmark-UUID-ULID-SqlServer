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
    internal class DataKeyUuidV7CIDetailConfig : IEntityTypeConfiguration<DataKeyUuidV7CIDetail>
    {
        public void Configure(EntityTypeBuilder<DataKeyUuidV7CIDetail> builder)
        {
            builder
                .HasKey(b => b.Id);
            //clustered index is default
            //.IsClustered(true);


            builder.Property(b => b.Id)
                .IsRequired()
                .ValueGeneratedNever();
            builder.Property(b => b.Data1)
                .IsRequired();
            builder.Property(b => b.Data2)
                .IsRequired();

            builder.HasOne<DataKeyUuidV7CI>()
                .WithMany(e => e.Details)
                .IsRequired();
        }
    }
}
