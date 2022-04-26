using Microsoft.EntityFrameworkCore;

namespace MultipleDbContext.Api.Data
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions options):base(options)
        {
        }
    }
}