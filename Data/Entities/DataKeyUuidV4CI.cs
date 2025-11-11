using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark_UUID_ULID_SqlServer.Data.Entities
{
    /// <summary>
    /// With Key UUID V4 - Clustered Index
    /// </summary>
    internal class DataKeyUuidV4CI
    {
        public required Guid Id { get; set; }
        public required int Counter { get; set; }
        public required IList<DataKeyUuidV4CIDetail> Details { get; set; }
    }
}
