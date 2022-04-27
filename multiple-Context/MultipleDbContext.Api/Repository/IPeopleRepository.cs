using MultipleDbContext.Api.Model;

namespace MultipleDbContext.Api.Repository
{
    public interface IPeopleRepository
    {
        void Post(People people, string contextName);
        void Put(People people, string contextName);
        List<People> GetAll(string contextName);
    }
}