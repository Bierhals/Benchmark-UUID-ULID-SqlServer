using Benchmark_UUID_ULID_SqlServer.Data;
using BenchmarkDotNet.Running;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Soll die DB neu erstellt werden J/N:");
if (Console.ReadKey().KeyChar == 'J')
    // Recreate DB
    using (BenchmarkContext context = new BenchmarkContext())
    {
        context.Database.EnsureDeleted();
        context.Database.Migrate();
    }

// Run Benchmarks
BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
//var summary = BenchmarkRunner
//    .Run<UuidVsUlidSqlInsert>();
