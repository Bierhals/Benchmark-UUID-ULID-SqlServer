using Benchmark_UUID_ULID_SqlServer.Data;
using Benchmark_UUID_ULID_SqlServer.Data.Entities;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;
using Microsoft.EntityFrameworkCore;

namespace Benchmark_UUID_ULID_SqlServer
{
    [SimpleJob(RunStrategy.Monitoring, launchCount: 1, iterationCount: 10, invocationCount: 1_000)]
    public class UuidVsUlidSqlInsert
    {
        private int iterationCounter = 0;

        /*[IterationSetup]
        public void IterationSetup() => iterationCounter++;*/

        [Benchmark(Baseline = true)]
        public async Task Uuid_V4_CI()
        {
            using BenchmarkContext context = new BenchmarkContext();
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
        public async Task Uuid_V7()
        {
            using BenchmarkContext context = new BenchmarkContext();
            context.DataKeyUuidV7s.Add(
                new Data.Entities.DataKeyUuidV7()
                {
                    Id = Guid.CreateVersion7(),
                    Counter = ++iterationCounter,
                    Details = new[] {
                            new DataKeyUuidV7Detail ()
                            {
                                Id = Guid.CreateVersion7(),
                                Data1 = iterationCounter,
                                Data2 = 1
                            },
                            new DataKeyUuidV7Detail ()
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
        public async Task Uuid_V7_Binary()
        {
            using BenchmarkContext context = new BenchmarkContext();
            context.DataKeyUuidV7Binarys.Add(
                new Data.Entities.DataKeyUuidV7Binary()
                {
                    Id = Guid.CreateVersion7(),
                    Counter = ++iterationCounter,
                    Details = new[] {
                            new DataKeyUuidV7BinaryDetail ()
                            {
                                Id = Guid.CreateVersion7(),
                                Data1 = iterationCounter,
                                Data2 = 1
                            },
                            new DataKeyUuidV7BinaryDetail ()
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
