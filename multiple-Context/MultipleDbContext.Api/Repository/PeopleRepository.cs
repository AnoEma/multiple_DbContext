using Microsoft.EntityFrameworkCore;
using MultipleDbContext.Api.Data;
using MultipleDbContext.Api.Model;

namespace MultipleDbContext.Api.Repository
{
    public class PeopleRepository : IPeopleRepository
    {
        private readonly ICollection<BaseContext> _context;

        public PeopleRepository(ICollection<BaseContext> context)
        {
            _context = context;
        }

        public List<People>? GetAll(string contextName)
        {
            var context = GetBaseContext(contextName);
            return context.Peoples?.ToList();
        }

        public void Post(People people, string contextName)
        {
            var context = GetBaseContext(contextName);
            var addedEntity = context.Attach(people);

            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Put(People people, string contextName)
        {
            var context = GetBaseContext(contextName);
            var updateEntity = context.Entry(people);

            updateEntity.State = EntityState.Modified;
            context.SaveChanges();
        }

        private BaseContext GetBaseContext(string contextName)
        {
            BaseContext? context = null;

            switch (contextName)
            {
                case "DbOneContext":
                    context = _context.FirstOrDefault(x => x is DbOneContext) as DbOneContext;
                    break;
                case "DbTwoContext":
                    context = _context.FirstOrDefault(x => x is DbTwoContext) as DbTwoContext;
                    break;
            }

            return context;
        }
    }
}