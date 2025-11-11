using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark_UUID_ULID_SqlServer.Data.Entities
{
    internal class DataKeyUlidBinary
    {
        public required Ulid Id { get; set; }
        public required int Counter { get; set; }
        public required IList<DataKeyUlidBinaryDetail> Details { get; set; }
    }
}
