using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark_UUID_ULID_SqlServer.Data.Entities
{
    internal class DataKeyUuidV7NCI
    {
        public required Guid Id { get; set; }
        public required int Counter { get; set; }
        public required IList<DataKeyUuidV7NCIDetail> Details { get; set; }
    }
}
