using MultipleDbContext.Api.Data;
using MultipleDbContext.Api.Model;

namespace MultipleDbContext.Api.Repository
{
    public class PeopleRepository : IPeopleRepository
    {
        ICollection<BaseContext> _context;

        public PeopleRepository(ICollection<BaseContext> context)
        {
            _context = context;
        }

        public List<People> GetAll(string contextName)
        {
            throw new NotImplementedException();
        }

        public void Post(People people, string contextName)
        {
            throw new NotImplementedException();
        }

        public void Put(People people, string contextName)
        {
            throw new NotImplementedException();
        }

        private BaseContext GetBaseContext(string contextName)
        {
            BaseContext? context = null;

            return context;
        }
    }
}