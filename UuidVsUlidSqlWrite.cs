using Benchmark_UUID_ULID_SqlServer.Data;
using Benchmark_UUID_ULID_SqlServer.Data.Entities;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Engines;

namespace Benchmark_UUID_ULID_SqlServer
{
    [SimpleJob(RunStrategy.ColdStart, launchCount: 1, warmupCount: 0, iterationCount: 100, invocationCount: 1_000)]
    [Config(typeof(Config))]
    public class UuidVsUlidSqlWrite
    {
        private const int InsertCount = 10;
        private int iterationCounter = 0;

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
            for (int i = 0; i < InsertCount; i++)
                context.DataKeyUuidV4CIs.Add(
                    new Data.Entities.DataKeyUuidV4CI()
                    {
                        Id = Guid.NewGuid(),
                        Counter = ++iterationCounter,
                        Details = new[] {
                                new DataKeyUuidV4CIDetail ()
                                {
                                    Id = Guid.NewGuid(),
                                    Data1 = iterationCounter,
                                    Data2 = 1
                                },
                                new DataKeyUuidV4CIDetail ()
                                {
                                    Id = Guid.NewGuid(),
                                    Data1 = iterationCounter,
                                    Data2 = 2
                                }
                        }
                    });
            await context.SaveChangesAsync();
        }

        [Benchmark]
        public async Task Uuid_V4_NCI()
        {
            using BenchmarkContext context = new BenchmarkContext();
            for (int i = 0; i < InsertCount; i++)
                context.DataKeyUuidV4NCIs.Add(
                    new Data.Entities.DataKeyUuidV4NCI()
                    {
                        Id = Guid.NewGuid(),
                        Counter = ++iterationCounter,
                        Details = new[] {
                                new DataKeyUuidV4NCIDetail ()
                                {
                                    Id = Guid.NewGuid(),
                                    Data1 = iterationCounter,
                                    Data2 = 1
                                },
                                new DataKeyUuidV4NCIDetail ()
                                {
                                    Id = Guid.NewGuid(),
                                    Data1 = iterationCounter,
                                    Data2 = 2
                                }
                        }
                    });
            await context.SaveChangesAsync();
        }

        [Benchmark]
        public async Task Uuid_V7_CI()
        {
            using BenchmarkContext context = new BenchmarkContext();
            for (int i = 0; i < InsertCount; i++)
                context.DataKeyUuidV7CIs.Add(
                    new Data.Entities.DataKeyUuidV7CI()
                    {
                        Id = Guid.CreateVersion7(),
                        Counter = ++iterationCounter,
                        Details = new[] {
                                new DataKeyUuidV7CIDetail ()
                                {
                                    Id = Guid.CreateVersion7(),
                                    Data1 = iterationCounter,
                                    Data2 = 1
                                },
                                new DataKeyUuidV7CIDetail ()
                                {
                                    Id = Guid.CreateVersion7(),
                                    Data1 = iterationCounter,
                                    Data2 = 2
                                }
                        }
                    });
            await context.SaveChangesAsync();
        }

        [Benchmark]
        public async Task Uuid_V7_NCI()
        {
            using BenchmarkContext context = new BenchmarkContext();
            for (int i = 0; i < InsertCount; i++)
                context.DataKeyUuidV7NCIs.Add(
                    new Data.Entities.DataKeyUuidV7NCI()
                    {
                        Id = Guid.CreateVersion7(),
                        Counter = ++iterationCounter,
                        Details = new[] {
                                new DataKeyUuidV7NCIDetail ()
                                {
                                    Id = Guid.CreateVersion7(),
                                    Data1 = iterationCounter,
                                    Data2 = 1
                                },
                                new DataKeyUuidV7NCIDetail ()
                                {
                                    Id = Guid.CreateVersion7(),
                                    Data1 = iterationCounter,
                                    Data2 = 2
                                }
                        }
                    });
            await context.SaveChangesAsync();
        }

        [Benchmark]
        public async Task Uuid_V7_Text()
        {
            using BenchmarkContext context = new BenchmarkContext();
            for (int i = 0; i < InsertCount; i++)
                context.DataKeyUuidV7Texts.Add(
                    new Data.Entities.DataKeyUuidV7Text()
                    {
                        Id = Guid.CreateVersion7(),
                        Counter = ++iterationCounter,
                        Details = new[] {
                                new DataKeyUuidV7TextDetail ()
                                {
                                    Id = Guid.CreateVersion7(),
                                    Data1 = iterationCounter,
                                    Data2 = 1
                                },
                                new DataKeyUuidV7TextDetail ()
                                {
                                    Id = Guid.CreateVersion7(),
                                    Data1 = iterationCounter,
                                    Data2 = 2
                                }
                        }
                    });
            await context.SaveChangesAsync();
        }

        [Benchmark]
        public async Task Uuid_V7_NCI_Binary()
        {
            using BenchmarkContext context = new BenchmarkContext();
            for (int i = 0; i < InsertCount; i++)
                context.DataKeyUuidV7NCIBinarys.Add(
                    new Data.Entities.DataKeyUuidV7NCIBinary()
                    {
                        Id = Guid.CreateVersion7(),
                        Counter = ++iterationCounter,
                        Details = new[] {
                                new DataKeyUuidV7NCIBinaryDetail ()
                                {
                                    Id = Guid.CreateVersion7(),
                                    Data1 = iterationCounter,
                                    Data2 = 1
                                },
                                new DataKeyUuidV7NCIBinaryDetail ()
                                {
                                    Id = Guid.CreateVersion7(),
                                    Data1 = iterationCounter,
                                    Data2 = 2
                                }
                        }
                    });
            await context.SaveChangesAsync();
        }

        [Benchmark]
        public async Task Uuid_V7_Binary_BigEndian()
        {
            using BenchmarkContext context = new BenchmarkContext();
            for (int i = 0; i < InsertCount; i++)
                context.DataKeyUuidV7BinaryBigEndians.Add(
                    new Data.Entities.DataKeyUuidV7BinaryBigEndian()
                    {
                        Id = Guid.CreateVersion7(),
                        Counter = ++iterationCounter,
                        Details = new[] {
                                new DataKeyUuidV7BinaryBigEndianDetail ()
                                {
                                    Id = Guid.CreateVersion7(),
                                    Data1 = iterationCounter,
                                    Data2 = 1
                                },
                                new DataKeyUuidV7BinaryBigEndianDetail ()
                                {
                                    Id = Guid.CreateVersion7(),
                                    Data1 = iterationCounter,
                                    Data2 = 2
                                }
                        }
                    });
            await context.SaveChangesAsync();
        }

        [Benchmark]
        public async Task Ulid_Text()
        {
            using BenchmarkContext context = new BenchmarkContext();
            for (int i = 0; i < InsertCount; i++)
                context.DataKeyUlidTexts.Add(
                    new Data.Entities.DataKeyUlidText()
                    {
                        Id = Ulid.NewUlid(),
                        Counter = ++iterationCounter,
                        Details = new[] {
                                new DataKeyUlidTextDetail ()
                                {
                                    Id = Ulid.NewUlid(),
                                    Data1 = iterationCounter,
                                    Data2 = 1
                                },
                                new DataKeyUlidTextDetail ()
                                {
                                    Id = Ulid.NewUlid(),
                                    Data1 = iterationCounter,
                                    Data2 = 2
                                }
                        }
                    });
            await context.SaveChangesAsync();
        }

        [Benchmark]
        public async Task Ulid_Binary()
        {
            using BenchmarkContext context = new BenchmarkContext();
            for (int i = 0; i < InsertCount; i++)
                context.DataKeyUlidBinarys.Add(
                new Data.Entities.DataKeyUlidBinary()
                {
                    Id = Ulid.NewUlid(),
                    Counter = ++iterationCounter,
                    Details = new[] {
                            new DataKeyUlidBinaryDetail ()
                            {
                                Id = Ulid.NewUlid(),
                                Data1 = iterationCounter,
                                Data2 = 1
                            },
                            new DataKeyUlidBinaryDetail ()
                            {
                                Id = Ulid.NewUlid(),
                                Data1 = iterationCounter,
                                Data2 = 2
                            }
                    }
                });
            await context.SaveChangesAsync();
        }
    }
}
