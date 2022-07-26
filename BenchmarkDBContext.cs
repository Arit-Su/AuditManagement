using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditBenchmarkModule.Models
{
    public class BenchmarkDBContext:DbContext
    {
        public BenchmarkDBContext(DbContextOptions<BenchmarkDBContext> options)
            : base(options)
        {

        }
        public DbSet<AuditBenchmark> AuditBenchmarkList { get; set; }

        
    }
}
