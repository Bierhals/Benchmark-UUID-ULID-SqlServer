using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

namespace Benchmark_UUID_ULID_SqlServer
{
    [SimpleJob(RunStrategy.Throughput, launchCount: 1, warmupCount: 10, iterationCount: 100, invocationCount: 5_000_000)]
    public class UuidVsUlid
    {
        [Benchmark(Baseline = true)]
        public Guid Uuid_V4() => Guid.NewGuid();

        [Benchmark]
        public Guid Uuid_V7() => Guid.CreateVersion7();

        [Benchmark]
        public Ulid Ulid() => System.Ulid.NewUlid();
    }
}
