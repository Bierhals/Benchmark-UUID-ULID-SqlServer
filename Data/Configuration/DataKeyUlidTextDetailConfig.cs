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
    internal class DataKeyUlidTextDetailConfig : IEntityTypeConfiguration<DataKeyUlidTextDetail>
    {
        public void Configure(EntityTypeBuilder<DataKeyUlidTextDetail> builder)
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
            builder.Property(b => b.Data1)
                .IsRequired();
            builder.Property(b => b.Data2)
                .IsRequired();

            builder.HasOne<DataKeyUlidText>()
                .WithMany(e => e.Details)
                .IsRequired();
        }
    }
}
