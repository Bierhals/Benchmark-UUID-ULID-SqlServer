using Benchmark_UUID_ULID_SqlServer.Data;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Engines;
using Microsoft.EntityFrameworkCore;

namespace Benchmark_UUID_ULID_SqlServer
{
    [SimpleJob(RunStrategy.Throughput)]
    [Config(typeof(Config))]
    public class UuidVsUlidSqlRead
    {
        private int TopCount = 10;
        private Guid lastId = Guid.Empty;
        private Ulid lastUlid = Ulid.Empty;

        private class Config : ManualConfig
        {
            public Config()
            {
                AddColumn(
                    StatisticColumn.P25,
                    StatisticColumn.P50,
                    StatisticColumn.P90,
                    StatisticColumn.P95,
                    StatisticColumn.P100);
            }
        }

        [Benchmark(Baseline = true)]
        public async Task Uuid_V4_CI()
        {
            using BenchmarkContext context = new BenchmarkContext();
            var data = await context.DataKeyUuidV4CIs
                .Where(d => d.Id > lastId)
                .OrderBy(d => d.Id)
                .Include(d => d.Details)
                .Take(10)
                .AsNoTracking()
                .ToListAsync();

            if (data.Count > 0)
                lastId = data.Last().Id;
        }

        [Benchmark]
        public async Task Uuid_V4_NCI()
        {
            using BenchmarkContext context = new BenchmarkContext();
            var data = await context.DataKeyUuidV4NCIs
                .Where(d => d.Id > lastId)
                .OrderBy(d => d.Id)
                .Include(d => d.Details)
                .Take(10)
                .AsNoTracking()
                .ToListAsync();

            if (data.Count > 0)
                lastId = data.Last().Id;
        }

        [Benchmark]
        public async Task Uuid_V7_CI()
        {
            using BenchmarkContext context = new BenchmarkContext();
            var data = await context.DataKeyUuidV7CIs
                .Where(d => d.Id > lastId)
                .OrderBy(d => d.Id)
                .Include(d => d.Details)
                .Take(10)
                .AsNoTracking()
                .ToListAsync();

            if (data.Count > 0)
                lastId = data.Last().Id;
        }

        [Benchmark]
        public async Task Uuid_V7_NCI()
        {
            using BenchmarkContext context = new BenchmarkContext();
            var data = await context.DataKeyUuidV7NCIs
                .Where(d => d.Id > lastId)
                .OrderBy(d => d.Id)
                .Include(d => d.Details)
                .Take(10)
                .AsNoTracking()
                .ToListAsync();

            if (data.Count > 0)
                lastId = data.Last().Id;
        }

        [Benchmark]
        public async Task Uuid_V7_Text()
        {
            using BenchmarkContext context = new BenchmarkContext();
            var data = await context.DataKeyUuidV7Texts
                .Where(d => d.Id > lastId)
                .OrderBy(d => d.Id)
                .Include(d => d.Details)
                .Take(10)
                .AsNoTracking()
                .ToListAsync();

            if (data.Count > 0)
                lastId = data.Last().Id;
        }

        [Benchmark]
        public async Task Uuid_V7_NCI_Binary()
        {
            using BenchmarkContext context = new BenchmarkContext();
            var data = await context.DataKeyUuidV7NCIBinarys
                .Where(d => d.Id > lastId)
                .OrderBy(d => d.Id)
                .Include(d => d.Details)
                .Take(10)
                .AsNoTracking()
                .ToListAsync();

            if (data.Count > 0)
                lastId = data.Last().Id;
        }

        [Benchmark]
        public async Task Uuid_V7_Binary_BigEndian()
        {
            using BenchmarkContext context = new BenchmarkContext();
            var data = await context.DataKeyUuidV7BinaryBigEndians
                .Where(d => d.Id > lastId)
                .OrderBy(d => d.Id)
                .Include(d => d.Details)
                .Take(10)
                .AsNoTracking()
                .ToListAsync();

            if (data.Count > 0)
                lastId = data.Last().Id;
        }

        [Benchmark]
        public async Task Ulid_Text()
        {
            using BenchmarkContext context = new BenchmarkContext();
            var data = await context.DataKeyUlidTexts
                .Where(d => d.Id.CompareTo(lastUlid) > 0)
                .OrderBy(d => d.Id)
                .Include(d => d.Details)
                .Take(10)
                .AsNoTracking()
                .ToListAsync();

            if (data.Count > 0)
                lastUlid = data.Last().Id;
        }

        [Benchmark]
        public async Task Ulid_Binary()
        {
            using BenchmarkContext context = new BenchmarkContext();
            var data = await context.DataKeyUlidBinarys
                .Where(d => d.Id.CompareTo(lastUlid) > 0)
                .OrderBy(d => d.Id)
                .Include(d => d.Details)
                .Take(10)
                .AsNoTracking()
                .ToListAsync();

            if (data.Count > 0)
                lastUlid = data.Last().Id;
        }
    }
}
