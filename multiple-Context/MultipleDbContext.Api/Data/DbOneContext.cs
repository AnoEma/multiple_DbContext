using Microsoft.EntityFrameworkCore;

namespace MultipleDbContext.Api.Data
{
    public class DbOneContext : BaseContext
    {
        public DbOneContext(DbContextOptions<DbOneContext> options) : base(options)
        {
        }
    }
}