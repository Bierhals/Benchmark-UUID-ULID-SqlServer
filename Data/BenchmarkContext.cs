using Benchmark_UUID_ULID_SqlServer.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark_UUID_ULID_SqlServer.Data
{
    internal class BenchmarkContext : DbContext
    {
        public DbSet<DataKeyUuidV4CI> DataKeyUuidV4CIs { get; set; }
        public DbSet<DataKeyUuidV4CIDetail> DataKeyUuidV4CIDetails { get; set; }
        public DbSet<DataKeyUuidV4NCI> DataKeyUuidV4NCIs { get; set; }
        public DbSet<DataKeyUuidV4NCIDetail> DataKeyUuidV4NCIDetails { get; set; }
        public DbSet<DataKeyUuidV7NCI> DataKeyUuidV7NCIs { get; set; }
        public DbSet<DataKeyUuidV7NCIDetail> DataKeyUuidV7NCIDetails { get; set; }
        public DbSet<DataKeyUuidV7CI> DataKeyUuidV7CIs { get; set; }
        public DbSet<DataKeyUuidV7CIDetail> DataKeyUuidV7CIDetails { get; set; }
        public DbSet<DataKeyUuidV7Text> DataKeyUuidV7Texts { get; set; }
        public DbSet<DataKeyUuidV7TextDetail> DataKeyUuidV7TextDetails { get; set; }
        public DbSet<DataKeyUuidV7NCIBinary> DataKeyUuidV7NCIBinarys { get; set; }
        public DbSet<DataKeyUuidV7NCIBinaryDetail> DataKeyUuidV7NCIBinaryDetails { get; set; }
        public DbSet<DataKeyUuidV7BinaryBigEndian> DataKeyUuidV7BinaryBigEndians { get; set; }
        public DbSet<DataKeyUuidV7BinaryBigEndianDetail> DataKeyUuidV7BinaryBigEndianDetails { get; set; }
        public DbSet<DataKeyUlidText> DataKeyUlidTexts { get; set; }
        public DbSet<DataKeyUlidTextDetail> DataKeyUlidTextDetails { get; set; }
        public DbSet<DataKeyUlidBinary> DataKeyUlidBinarys { get; set; }
        public DbSet<DataKeyUlidBinaryDetail> DataKeyUlidBinaryDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=.;Database=Benchmark;Trusted_Connection=True;TrustServerCertificate=True;ConnectRetryCount=0");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BenchmarkContext).Assembly);
        }
    }
}
