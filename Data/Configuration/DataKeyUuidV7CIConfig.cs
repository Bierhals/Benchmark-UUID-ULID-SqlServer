using Benchmark_UUID_ULID_SqlServer.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark_UUID_ULID_SqlServer.Data.Configuration
{
    internal class DataKeyUuidV7CIConfig : IEntityTypeConfiguration<DataKeyUuidV7CI>
    {
        public void Configure(EntityTypeBuilder<DataKeyUuidV7CI> builder)
        {
            builder
                .HasKey(b => b.Id);
            //clustered index is default
            //.IsClustered(true);

            builder.Property(b => b.Id)
                .IsRequired()
                .ValueGeneratedNever();
            builder.Property(b => b.Counter)
                .IsRequired();

            builder.HasMany(b => b.Details);
        }
    }
}
