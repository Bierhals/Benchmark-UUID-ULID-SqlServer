using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark_UUID_ULID_SqlServer.Data.Entities
{
    internal class DataKeyUuidV7NCIBinaryDetail
    {
        public required Guid Id { get; set; }
        public required int Data1 { get; set; }
        public required int Data2 { get; set; }
    }
}
