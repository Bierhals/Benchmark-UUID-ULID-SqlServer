
using Benchmark_UUID_ULID_SqlServer;
using Benchmark_UUID_ULID_SqlServer.Data;
using BenchmarkDotNet.Running;
using Microsoft.EntityFrameworkCore;

using (BenchmarkContext context = new BenchmarkContext())
{
    context.Database.EnsureDeleted();
    context.Database.Migrate();
}
//BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
var summary = BenchmarkRunner
    .Run<UuidVsUlidSqlInsert>();
