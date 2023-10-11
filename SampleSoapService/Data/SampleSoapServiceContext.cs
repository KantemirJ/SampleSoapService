using Microsoft.EntityFrameworkCore;
using SampleSoapService.Models;

namespace SampleSoapService.Data
{
    public class SampleSoapServiceContext : DbContext
    {
        public SampleSoapServiceContext(DbContextOptions<SampleSoapServiceContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; } = default!;
    }
}