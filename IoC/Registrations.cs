using EntityFramework.DbContextScope;
using EntityFramework.DbContextScope.Interfaces;
using SimpleInjector;
using Zipper.Repository;
using Zipper.Sql;
using Zipper.Workers;

namespace Zipper.IoC
{
    public static class Registrations
    {
        public static void RegisterTypes(Container container)
        {
            // Ensure only one DbContext is used per request - used for read-only queries only container.Register<PCSubsDBContext>(() =>new PCSubsDBContext(GetConnectionStringForCurrentRequest());
            container.Register<DatabaseContext>(Lifestyle.Singleton);
            container.Register<DatabaseContextFrm>(Lifestyle.Singleton);
           // container.Register<DatabaseContextFrm>(() => new DatabaseContextFrm());

            // This is our really helpful UnitOfWork implementation. Read about it here: http://mehdi.me/ambient-dbcontext-in-ef6/
            container.Register<IAmbientDbContextLocator, AmbientDbContextLocator>(Lifestyle.Transient);
            container.Register<IDbContextScopeFactory>(() => new DbContextScopeFactory(), Lifestyle.Transient);

            //Automatically register Generic repositories
            container.Register(typeof(IReadOnlyRepository<>), typeof(ReadOnlyRepository<>), Lifestyle.Transient);
            container.Register(typeof(IReadOnlyRepositoryForm<>), typeof(ReadOnlyRepositoryForm<>), Lifestyle.Transient);
            container.Register(typeof(IRepository<>), typeof(Repository<>), Lifestyle.Transient);
           container.Register(typeof( IRepositoryForm<>),typeof(RepositoryForm<>),Lifestyle.Transient);
            //Register Workers
            container.Register(typeof(ProjectTaskAssetSubmittedWorker));

            // Make sure everything registered fine
            container.Verify();
        }
    }
}
