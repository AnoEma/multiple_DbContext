using Microsoft.EntityFrameworkCore;
using MultipleDbContext.Api.Model;

namespace MultipleDbContext.Api.Data
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions options):base(options)
        {
        }
        public DbSet<People>? Peoples { get; set; }
    }
}