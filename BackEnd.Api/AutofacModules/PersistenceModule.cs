using Autofac;
using BackEnd.Domain.Providers;
using BackEnd.Infrastructure.Persistence.Querying.Providers;
using BackEnd.Infrastructure.Persistence.Querying.Queries;
using BackEnd.Infrastructure.Persistence.Repositories;

namespace BackEnd.Api.AutofacModules
{
    public class PersistenceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(DebtorRepository).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(DebtorQuery).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterType<DbConnectionProvider>().As<IDbConnectionProvider>().InstancePerLifetimeScope();
        }
    }
}
