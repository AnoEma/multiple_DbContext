using Autofac;
using MultipleDbContext.Api.Data;
using MultipleDbContext.Api.Repository;
using Module = Autofac.Module;

namespace MultipleDbContext.Api.Ioc
{
    public class AutoFacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DbOneContext>().As<BaseContext>();
            builder.RegisterType<DbTwoContext>().As<BaseContext>();
            builder.RegisterType<PeopleRepository>().As<IPeopleRepository>();
        }
    }
}