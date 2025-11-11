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
    internal class DataKeyUlidTextConfig : IEntityTypeConfiguration<DataKeyUlidText>
    {
        public void Configure(EntityTypeBuilder<DataKeyUlidText> builder)
        {
            builder
                .HasKey(b => b.Id);
            //clustered index is default
            //.IsClustered(true);

            builder.Property(b => b.Id)
                .HasColumnType("char(26)")
                .HasConversion(
                    v => v.ToString(),
                    v => Ulid.Parse(v))
                .IsRequired()
                .ValueGeneratedNever();
            builder.Property(b => b.Counter)
                .IsRequired();

            builder.HasMany(b => b.Details);
        }
    }
}
