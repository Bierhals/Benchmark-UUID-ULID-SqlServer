using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark_UUID_ULID_SqlServer.Data.Entities
{
    /// <summary>
    /// UUID V4 - Data with non clustered Index
    /// </summary>
    internal class DataKeyUuidV4NCI
    {
        public required Guid Id { get; set; }
        public required int Counter { get; set; }
        public required IList<DataKeyUuidV4NCIDetail> Details { get; set; }
    }
}
