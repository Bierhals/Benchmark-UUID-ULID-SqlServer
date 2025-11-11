using BenchmarkDotNet.Attributes;

namespace Benchmark_UUID_ULID_SqlServer
{
    public class UuidVsUlid
    {
        [Benchmark]
        public Guid Uuid_V4() => Guid.NewGuid();

        [Benchmark]
        public Guid Uuid_V7() => Guid.CreateVersion7();

        [Benchmark]
        public Ulid Ulid() => System.Ulid.NewUlid();
    }
}
