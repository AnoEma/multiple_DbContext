using Microsoft.EntityFrameworkCore;

namespace MultipleDbContext.Api.Data
{
    public class DbTwoContext : BaseContext
    {
        public DbTwoContext(DbContextOptions<DbTwoContext> options) : base(options)
        {
        }
    }
}