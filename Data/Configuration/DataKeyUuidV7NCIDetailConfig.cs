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
    internal class DataKeyUuidV7NCIDetailConfig : IEntityTypeConfiguration<DataKeyUuidV7NCIDetail>
    {
        public void Configure(EntityTypeBuilder<DataKeyUuidV7NCIDetail> builder)
        {
            builder
                .HasKey(b => b.Id)
                .IsClustered(false);


            builder.Property(b => b.Id)
                .IsRequired()
                .ValueGeneratedNever();
            builder.Property(b => b.Data1)
                .IsRequired();
            builder.Property(b => b.Data2)
                .IsRequired();

            builder.HasOne<DataKeyUuidV7NCI>()
                .WithMany(e => e.Details)
                .IsRequired();
        }
    }
}
